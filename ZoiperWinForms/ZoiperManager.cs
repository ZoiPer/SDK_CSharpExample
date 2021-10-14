using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CliWrapper;
using System.Threading;
using ZDK_NET;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace ZoiperWinForms
{
    public class ZoiperManager
    {
        int countInits = 0;
        const long InvalidHandle = (long)-1;
        long UserId = InvalidHandle;
        //*
        public enum eSecureCertError_tag
        {
            E_SCERR_NONE = 0            // No bits set, all OK
            , E_SCERR_ISSUER = 1            // Issuer untrusted/not found/not valid/wrong purpose
            , E_SCERR_CERT = 2          // Peer certificate broken (wrong Signature/Public Key/Purpose)
            , E_SCERR_DATE = 4          // Certificate not yet valid or already expired
            , E_SCERR_REVOKED = 8           // Certificate was revoked or rejected
            , E_SCERR_INTERNAL = 16     // Internal or other unrecognized error--ask for debug log...
            , E_SCERR_NAME = 32     // Certificate names mismatch
        }//*/
        Account probingAccount = null;

        public class VoIPUser
        {
            public static CallEventsHandler ceh = null;
            public static VideoRendererEventsHandler vreh = null;

            public VoIPUser()
            {
                ActiveCalls = new Dictionary<long, Call>();
            }

            public String UserName
            {
                get;
                set;
            }

            public long UserId
            {
                get;
                set;
            }

            public bool EnableSRTP
            {
                get;
                set;
            }

            public override string ToString()
            {
                string str = UserName;
                if (EnableSRTP)
                {
                    str += " (SRTP)";
                }
                return str;
            }

            public bool IsRegistered
            {
                get;
                set;
            }

            public Account Acc
            {
                get;
                set;
            }

            public ZoiperManager Manager
            {
                get;
                set;
            }

            public bool RegisterUser()
            {
                var result = Acc.RegisterAccount();
                return result.Code == ResultCode.Ok;
            }

            public bool UnregisterUser()
            {
                var result = Acc.UnRegister();
                return result.Code == ResultCode.Ok;
            }

            public bool MakeCall(Call activeCall)
            {
                if (activeCall == null)
                {
                    return false;
                }
                long callId = activeCall.CallHandle;

                ceh = new CallEventsHandler();
                ceh.OnCallExtendedError += Manager.ZDK_NET_OnCallExtendedError;
                ceh.OnCallStatusChanged += Manager.ZDK_NET_OnCallStatusChanged;
                ceh.OnCallSecurityLevelChanged += Manager.ZDK_NET_OnCallSecurityLevelChanged;
                ceh.OnCallDTMFResult += Manager.ZDK_NET_OnCallDTMFResult;
                //ceh.OnCallNetworkQualityLevel += Manager.ZDK_NET_OnCallNetworkQualityLevel;
                //ceh.OnCallNetworkStatistics += Manager.ZDK_NET_OnCallNetworkStatistics;
                ceh.OnCallTransferFailure += Manager.ZDK_NET_OnCallTransferFailure;
                ceh.OnCallTransferStarted += Manager.ZDK_NET_OnCallTransferStarted;
                ceh.OnCallTransferSucceeded += Manager.ZDK_NET_OnCallTransferSucceeded;
                ceh.OnCallZrtpFailed += Manager.ZDK_NET_OnCallZrtpFailed;
                ceh.OnCallZrtpSuccess += Manager.ZDK_NET_OnCallZrtpSuccess;
                ceh.OnCallZrtpSecondaryError += Manager.ZDK_NET_OnCallZrtpSecondaryError;
                ceh.OnVideoOffered += Manager.ZDK_NET_OnVideoOffered;
                ceh.OnVideoStarted += Manager.ZDK_NET_OnVideoStarted;
                ceh.OnVideoStopped += Manager.ZDK_NET_OnVideoStopped;
                ceh.OnVideoCameraChanged += Manager.ZDK_NET_OnVideoCameraChanged;

                GC.KeepAlive(ceh);

                activeCall.SetCallStatusListener(ceh);

                vreh = new VideoRendererEventsHandler();
                vreh.OnVideoFrameReceived += Manager.ZDK_NET_OnVideoFrameReceived;
                GC.KeepAlive(vreh);

                activeCall.SetVideoRendererNotificationsListener(vreh);

                ActiveCalls[callId] = activeCall;
                return true;
            }

            public bool MakeCall(String callee)
            {
                Call activeCall = null;
                try
                {
                    activeCall = Acc.CreateCall(callee, true, false);
                    //activeCall = Acc.CreateCall(callee, true, true);
                }
                catch (ArgumentNullException)
                {
                    return false;
                }
                return MakeCall(activeCall);
            }

            public Dictionary<long, Call> ActiveCalls
            {
                get;
                set;
            }

            public void SendMessage(String callee, String message)
            {
                ZDK_NET.Message msg = Acc.CreateMessage(MessageType.Simple);
                msg.Peer = callee;
                msg.Content = message;
                msg.SendMessage();
            }
        }

        private void ZDK_NET_OnCallTransferSucceeded(Call call)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallTransferSucceeded");
        }

        private void ZDK_NET_OnCallZrtpFailed(Call call, ExtendedError error)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallZrtpFailed: call= " + call.CallHandle + "(" + call.CalleeName + "), error= " + error.Message);
        }

        private void ZDK_NET_OnCallZrtpSuccess(Call call, string zidHex, int knownPeer, int cacheMismatch, int peerKnowsUs, ZRTPSASEncoding sasEncoding, string sas, ZRTPHashAlgorithm hash,
                                               ZRTPCipherAlgorithm cipher, ZRTPAuthTag authTag, ZRTPKeyAgreement keyAgreement)
        {
            if ((knownPeer != 0) && (cacheMismatch == 0) && (peerKnowsUs != 0))
            {
                call.ConfirmZrtpSas(true);
            }
            else
            {
                DialogResult result = MessageBox.Show("SAS Verification is \"" + sas + "\". Please compare the string with your peer!", "SAS Verification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    call.ConfirmZrtpSas(true);
                else
                    call.ConfirmZrtpSas(false);
            }
        }

        private void ZDK_NET_OnCallZrtpSecondaryError(Call call, int channel, ExtendedError error)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallZrtpSecondaryError: call= " + call.CallHandle + "(" + call.CalleeName + "), error= " + error.Message);
        }

        private void ZDK_NET_OnCallTransferStarted(Call call, string name, string number, string URI)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallTransferStarted name: " + name + " number: " + number + " URI: " + URI);
        }

        private void ZDK_NET_OnCallTransferFailure(Call call, ExtendedError errorCode)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallTransferFailure reason: " + errorCode.Message);
        }

        private void ZDK_NET_OnCallNetworkStatistics(Call call, NetworkStatistics networkStatistics)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallNetworkStatistics TotalOutputBytes: " + networkStatistics.TotalOutputBytes);
        }

        private void ZDK_NET_OnCallNetworkQualityLevel(Call call, int CallChannel, int QualityLevel)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallNetworkQualityLevel CallChannel: " + CallChannel + " QualityLevel: " + QualityLevel);
        }

        private void ZDK_NET_OnCallDTMFResult(Call call, Result lResult)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallDTMFResult lResult: " + lResult);
        }

        private void ZDK_NET_OnCallSecurityLevelChanged(Call call, CallMediaChannel channel, CallSecurityLevel level)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallSecurityLevelChanged channel: " + channel.ToString() + " level: " + level.ToString());
        }

        public Dictionary<long, VoIPUser> ActiveUsers = new Dictionary<long, VoIPUser>();
        private Context ctx = null;

        private void CreateContext()
        {
            ctx = new Context();

            ContextEventsHandler cthEvH = new ContextEventsHandler();
            cthEvH.OnContextActivationCompleted += ZDK_NET_OnContextActivationCompleted;
            cthEvH.OnContextSecureCertStatus += ZDK_NET_OnContextSecureCertStatus;
            ctx.SetStatusListener(cthEvH);
        }

        public bool Initialize(String path ,String certUserName, String certPassword, LoggingLevel logLevel)
        {
            if (ctx == null)
            {
                CreateContext();
            }

            string LogFile = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\zdk.net.log.txt";
            ctx.Logger.LogOpen(LogFile, null, logLevel, 0);

            if (path != "" && countInits == 0)
            {
                ctx.Activation.CreateOfflineActivationFileSDK(path, certUserName, certPassword);
                countInits++;
                return true;
            }
            else if (1 == countInits)
            {
                ctx.Activation.StartSDK(path + "\\certificate", certUserName, certPassword);
                countInits--;
                return true;
            }
            else
            {
                ctx.Activation.StartSDK("", certUserName, certPassword);
            }

            return true;
        }

        private void ZDK_NET_OnUnhandledCallback(string message)
        {
            OnZoiperEvent("OnUnhandledCallback: " + message);
        }

        internal void StartContext()
        {
            ctx.Configuration.SIPUdpPort = 44444;
            ctx.Configuration.RTPPort = 55555;

            var res = ctx.StartContext();
            if (res.Code != ResultCode.Ok)
                OnZoiperEvent("StartContext: Failed with reason= " + res.Text);

            ctx.VideoControls.SetFormat(352, 288, 6);
        }

        internal void StopContext()
        {
            //ctx.StopContext();
        }

        private string ParseErrorMask(int mask)
        {
            string errorMask = "";
            int[] values = (int[])Enum.GetValues(typeof(eSecureCertError_tag));
            for (int i = 0; i < values.Length; i++)
            {
                int val = values[i];
                if ((val & mask) > 0)
                {
                    errorMask += ", " + Enum.GetName(typeof(eSecureCertError_tag), val);
                }
            }
            errorMask = errorMask.TrimStart(new char[] { ',', ' ' });
            return errorMask;
        }

        private void ZDK_NET_OnContextSecureCertStatus(Context context, SecureCertData secureCert)
        {
            string errorMask = ParseErrorMask(secureCert.errorMask);
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnContextSecureCertStatus ActualNameList: " + secureCert.ActualNameList + " CertIssuer:" + secureCert.CertIssuer + " errorMask: " + errorMask);
        }

        private void ZDK_NET_OnContextActivationCompleted(ZDK_NET.Context context, ZDK_NET.ActivationResult secureCert)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnActivationCompleted Build: " + secureCert.Build + " Reason:" + secureCert.Reason);

            if (secureCert.Status == ActivationStatus.Success)
            {
                //"StartContext()" MUST NOT be invoked from any callback!!! Simply call it from a new thread.
                Thread t = new Thread(new ThreadStart(StartContext));
                t.Start();

                //OnActivationSuccess(secureCert.Reason);
            }
            else
            {
                OnActivationError(secureCert.Reason);
            }
        }

        private void ZDK_NET_OnCallExtendedError(Call call, ExtendedError error)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallExtendedError message: " + error.Message);
        }

        private void ZDK_NET_OnCallStatusChanged(Call call, CallStatus status)
        {
            if (status.LineStatus == CallLineStatus.Terminated)
            {
                if (ActiveUsers[UserId].ActiveCalls.Keys.Contains(call.CallHandle))
                    ActiveUsers[UserId].ActiveCalls.Remove(call.CallHandle);
            }
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnCallStatusChanged status: " + status.LineStatus);
        }

        private void ZDK_NET_OnVideoOffered(Call call)
        {
            if (OnVideoOffered != null)
                OnVideoOffered(call);
        }


        private void ZDK_NET_OnVideoStarted(Call call, OriginType  origin)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnVideoStarted");
        }


        private void ZDK_NET_OnVideoCameraChanged(Call call)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnVideoCameraChanged");
        }

        private void ZDK_NET_OnVideoStopped(Call call, OriginType origin)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnVideoStopped");
        }

        private void ZDK_NET_OnVideoFrameReceived(byte[] pBuffer, int length, int width, int heigth)
        {
            if (OnFrameReceived != null)
                OnFrameReceived(pBuffer, width, heigth);
        }

        public Conference CreateConference(List<Call> calls)
        {
            return ctx.ConferenceProvider.CreateConference(calls);
        }

        private Account getProbingAccount()
        {
            if (probingAccount == null)
            {
                probingAccount = ctx.AccountProvider.CreateUserAccount();

                //AccEventHandler.OnProbeError += Zoiper_OnProbeError;
                //AccEventHandler.OnProbeFailed += Zoiper_OnProbeFailed;
                //AccEventHandler.OnProbeState += Zoiper_OnProbeState;
                //AccEventHandler.OnProbeSuccess += Zoiper_OnProbeSuccess;
            }
            return probingAccount;
        }

        public bool ProbeSIPTransport(Int32 transportType, String username, String password, String server)
        {
            if (null == ctx)
                return false;
            Account account = getProbingAccount();
            account.ProbeSipTransport(server, "", username, username, password);
            return true;
        }

        public bool AddUser(Int32 transportType, String username, String password, String server, bool SRTP , bool ZRTP , bool FMTP , bool Privacy , bool Stun , bool Preconditions , bool RTCPFeedback, string protocol)
        {
            if (null == ctx)
                return false;
            Account account = ctx.AccountProvider.CreateUserAccount();

            account.AccountName = username;

            AccountConfig regCfg = ctx.AccountProvider.CreateAccountConfiguration();

            regCfg.UserName = username;
            regCfg.Password = password;

            if ("SIP" == protocol)
            {
                regCfg.Type = ProtocolType.SIP;
                regCfg.SIP = ctx.AccountProvider.CreateSIPConfiguration();

                if (ZRTP)
                {
                    var hash = new List<ZRTPHashAlgorithm>();
                    hash.Add(ZRTPHashAlgorithm.s384);
                    hash.Add(ZRTPHashAlgorithm.s256);

                    var cipher = new List<ZRTPCipherAlgorithm>();
                    cipher.Add(ZRTPCipherAlgorithm.cipher_aes3);
                    cipher.Add(ZRTPCipherAlgorithm.cipher_aes2);
                    cipher.Add(ZRTPCipherAlgorithm.cipher_aes1);

                    var auth = new List<ZRTPAuthTag>();
                    auth.Add(ZRTPAuthTag.hs80);
                    auth.Add(ZRTPAuthTag.hs32);

                    var keyAgreement = new List<ZRTPKeyAgreement>();
                    keyAgreement.Add(ZRTPKeyAgreement.dh3k);
                    keyAgreement.Add(ZRTPKeyAgreement.dh2k);
                    keyAgreement.Add(ZRTPKeyAgreement.ec38);
                    keyAgreement.Add(ZRTPKeyAgreement.ec25);

                    var sasEncoding = new List<ZRTPSASEncoding>();
                    sasEncoding.Add(ZRTPSASEncoding.sasb256);
                    sasEncoding.Add(ZRTPSASEncoding.sasb32);

                    regCfg.SIP.ZRTP = ctx.AccountProvider.CreateZRTPConfiguration();
                    regCfg.SIP.ZRTP.EnableZRTP = ZRTP;
                    regCfg.SIP.ZRTP.Hash = hash;
                    regCfg.SIP.ZRTP.Cipher = cipher;
                    regCfg.SIP.ZRTP.KeyAgreement = keyAgreement;
                    regCfg.SIP.ZRTP.SasEncoding = sasEncoding;
                    regCfg.SIP.ZRTP.Auth = auth;
                    regCfg.SIP.ZRTP.CacheExpiry = -1;
                }

                if (RTCPFeedback)
                {
                    regCfg.SIP.RTCPFeedback = RTCPFeedbackType.Compatibility;  // Include AVP and AVPF video media profiles in the SDP for backward compatibility
                }
                else
                {
                    regCfg.SIP.RTCPFeedback = RTCPFeedbackType.Off; // Include only AVP video media profile in the SDP
                }

                if (Stun)
                {
                    regCfg.SIP.Stun = ctx.AccountProvider.CreateStunConfiguration();
                    regCfg.SIP.Stun.STUNEnabled = true;
                    regCfg.SIP.Stun.STUNServer = "stun.zoiper.com";
                    regCfg.SIP.Stun.STUNPort = 3478;
                    regCfg.SIP.Stun.STUNRefresh = 30000;
                }
                regCfg.SIP.EnablePreconditions = Preconditions; // Reliable Provisional MUST be enabled
                regCfg.SIP.Transport = (TransportType)transportType;
                regCfg.SIP.Domain = server;
                regCfg.SIP.EnableVideoFMTP = FMTP;
                regCfg.SIP.EnablePrivacy = Privacy;
                // This is for TLS
                // Note it has to be enabled both sides
                // if you get error "415 Unsupported Media Type"
                // or "Can't find matching codec in SDP (code: 2)"
                // Make sure "EnableSRTP = true" and
                // "SRTP key negociation = SDES" in Zoiper5
                // On succes and secure connection you will get the
                // "OnCallSecurityLevelChanged channel: Audio level: SdesSrtp"
                // event
                regCfg.SIP.EnableSRTP = SRTP;
            }
            else if ("IAX" == protocol)
            {
                ctx.AddProtocol(ProtocolType.IAX, 4569);
                regCfg.Type = ProtocolType.IAX;
                regCfg.IAX = ctx.AccountProvider.CreateIAXConfiguration();
                regCfg.IAX.Host = server;
            }
            List<AudioVideoCodecs> codecs = new List<AudioVideoCodecs>();
            codecs.Add(AudioVideoCodecs.OPUS_WIDE);
            codecs.Add(AudioVideoCodecs.PCMU);
            // This is for the videocall
            codecs.Add(AudioVideoCodecs.vp8);

            account.MediaCodecs = codecs;

            AccountEventsHandler AccEventHandler = new AccountEventsHandler();
            AccEventHandler.OnAccountStatusChanged += Zoiper_OnAccountStatusChanged;
            AccEventHandler.OnAccountExtendedError += Zoiper_OnAccountExtendedError;
            AccEventHandler.OnAccountRetryingRegistration += Zoiper_OnAccountRetryingRegistration;
            AccEventHandler.OnAccountChatMessageReceived += Zoiper_OnAccountChatMessageReceived;
            AccEventHandler.OnAccountIncomingCall += Zoiper_OnAccountIncomingCall;

            account.SetStatusEventListener(AccEventHandler);

            account.Configuration = regCfg;

            if (ResultCode.Ok == account.CreateUser().Code)
                UserId = account.AccountID;

            if (UserId != InvalidHandle)
            {
                ActiveUsers[UserId] = new VoIPUser
                {
                    Manager = this,
                    Acc = account,
                    UserName = username,
                    UserId = UserId,
                    EnableSRTP = SRTP
                };
                return true;
            }
            return false;
        }

        public delegate void ZoiperEvent(String eventText);
        public delegate void ZoiperFrameEvent(byte[] frame, int width, int heigth);
        public delegate void ZoiperCallEvent(Call call);
        public ZoiperEvent OnZoiperEvent;
        public ZoiperEvent OnActivationSuccess;
        public ZoiperEvent OnActivationError;
        public ZoiperCallEvent OnVideoOffered;
        public ZoiperFrameEvent OnFrameReceived;

        //public delegate void OnProbeError(ZDK_NET::Account^ account, ZDK_NET::ProbeState curState, int causeCode);
        //public delegate void OnProbeState(ZDK_NET::Account^ account, ZDK_NET::ProbeState newState);
        //public delegate void OnProbeSuccess(ZDK_NET::Account^ account, ZDK_NET::TransportType transport);
        //public delegate void OnProbeFailed(ZDK_NET::Account^ account, int CauseCode);
        

        public void Zoiper_OnProbeError(Account account, int curState, int causeCode)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnProbeError probeId: " + curState.ToString());
        }

        public void Zoiper_OnProbeFailed(Account account, long probeId)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnProbeFailed probeId: " + probeId.ToString());
        }

        public void Zoiper_OnProbeState(Account account, long probeId, int newState)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnProbeState probeId: " + probeId.ToString() + " newState: " + newState.ToString());
        }

        public void Zoiper_OnProbeSuccess(Account account, long probeId)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnProbeSuccess probeId: " + probeId.ToString());
        }

        public void Zoiper_OnAccountStatusChanged(Account account, AccountStatus status, int statusCode)
        {
            if (status == AccountStatus.Registered)
                ActiveUsers[UserId].IsRegistered = true;
            else if (status == AccountStatus.Unregistered)
                ActiveUsers[UserId].IsRegistered = false;

            if (OnZoiperEvent != null)
                OnZoiperEvent("OnAccountStatusChanged Status: " + status.ToString() + " Code: " + statusCode);
        }

        public void Zoiper_OnAccountExtendedError(Account account, ExtendedError error)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("AccountExtendedError Message: " + error.Message);
        }

        public void Zoiper_OnAccountRetryingRegistration(Account account, int isRetrying, int inSeconds)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("AccountRetryingRegistration isRetrying: " + isRetrying + " inSeconds: " + inSeconds);
        }

        public void Zoiper_OnAccountChatMessageReceived(Account account, string pPeer, string pContent)
        {
            if (OnZoiperEvent != null)
                OnZoiperEvent("AccountChatMessageReceived: " + pPeer + " message: " + pContent);
        }

        public void Zoiper_OnAccountIncomingCall(Account account, Call call)
        {
            ActiveUsers[UserId].MakeCall(call);
            DialogResult result = MessageBox.Show("Accept call from: " + call.CalleeName, "Incomming call", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var res = call.AcceptCall();
                if ((ResultCode.Ok == res.Code) && !ActiveUsers[UserId].ActiveCalls.Keys.Contains(call.CallHandle))
                {
                    ActiveUsers[UserId].ActiveCalls.Add(call.CallHandle, call);
                }
            }
            else
                call.HangUp();

            if (OnZoiperEvent != null)
                OnZoiperEvent("AccountIncomingCall: " + call.CalleeName + " number: " + call.CalleeNumber);
        }

        public void createOfflineCert(string path, string username, string password)
        {
            if (ctx == null)
            {
                CreateContext();
            }
            ctx.Activation.CreateOfflineActivationFileSDK(path, username, password);
        }

    }
}