# Before you start

## Purpose of this documentation

This guide assists you in rapidly developing your VoIP application with Zoiper SDK 2.0. This manual contains an overview of the entities in the SDK with a lot of practical examples of implementation, usage and configuration.

**By default zdk.net is not included in the example. If you still don't have the zdk.net library, please contact us on zoiper.com.**

## Licensing

To enjoy the powerful benefits of Zoiper SDK 2.0, you need a license. Depending on your needs, you can buy 2 different types of licenses:

- Installation license per end-user
- Unlimited installations;

Please [<span style="color:orange">contact Zoiper</span>](mailto:sales@zoiper.com) for more details and test licenses or to receive licenses for testing purposes.

## Threading model

Zoiper SDK 2.0 is thread-safe. Shared objects can be called simultaneously from multiple threads. All callbacks from the SDK modules to the application code are performed in the context of the application thread which invokes the respective functions and methods.

In order to receive callbacks, the SDK needs to receive processing time from your application core. You can achieve this by invoking the respective functions.

On Android, iOS, and macOS, the main UI thread usually handles the assignment of processing time to the SDK.

Regarding sockets and transports, the SDK manages and utilizes the threads internally. For the interaction with sockets and transports, the SDK also internally manages and utilizes its own separate thread. As a result, the application code can use the processing time without blocking the SDK sockets.

## More resources

Inside the SDK packages, you can find the respective reference and examples of basic usage for all:

- methods
- functions
- APIs
- callbacks
- etc.

## Third-party software

The SDK is (partially) built with:

- JThread, Copyright (C) 2000-2005 Jori Liesenborgs (jori@lumumba.uhasselt.be)
- JRTPLIB, part of JRTPLIB Copyright (C) 1999-2005 Jori Liesenborgs
- GSM, Copyright 1992, 1993, 1994 by Jutta Degener and Carsten Bormann, Technische Universitaet Berlin
- iLBC, iLBC Speech Coder ANSI-C Source Code iLBC_define.h Copyright (C) The Internet Society (2004). All Rights Reserved.
- SPEEX The Xiph OSC and the Speex Parrot logos are trademarks (TM) of Xiph.Org.
- OpenLDAP, Copyright 1999-2003 The OpenLDAP Foundation, Redwood City, California, USA. All Rights Reserved.
- PortAudio, Copyright (C) 1999-2002 Ross Bencina and Phil Burk
- PortMixer, PortMixer, Windows WMME Implementation, Copyright (C) 2002, Written by Dominic Mazzoni and Augustus Saunders
- Resiprocate, The Vovida license The Vovida Software License, Version 1.0, Copyright (C) 2000 Vovida Networks, Inc. All rights reserved.
- This product includes cryptographic software written by Eric Young (eay@cryptsoft.com).
- This product includes software written by Tim Hudson (tjh@cryptsoft.com).

Please contact [<span style="color:orange">sales@zoiper.com</span>](mailto:sales@zoiper.com) for more information.


## Introduction to Zoiper SDK 2.0 Windows .Net Framework

This section explains how to develop your VoIP application with .Net Framework on Windows in combination with the Zoiper SDK 2.0 for Windows .Net.
The SDK is an all-inclusive solution for developing VoIP applications for Windows with:

- audio calls (SIP, IAX)
- video call (SIP)
- presence
- messaging
- call recordings
- oher functionalities

The SDK 2.0 consists of:

- a dynamic library with all the respective headers in it
- some helper libraries (e.g. LAME.dll).

### Hardware and software requirements

| Requirement | Description |
|--------|--------|
| Processor | Intel Core i3 or better |
| Memory | 4GB(minimum) 8 GB(recommended) |
| Hard disk space | 1 GB |
| Environent | Microsoft Visual Studio 2015 or newer |
| .Net Framework | .Net Framework 4.5.2 or newer |
| Operating system (Development environment) | Windows |
| Operating system (Runtime environment) | Windows 8 or above |
| Architecture | x86, x64 |

### Contents of the SDK package

| Folder | Description |
|--------|--------|
| package/Documentation | Contains the html Zoiper SDK Documentation. To open it in your browser, click on the index.html file. |
| package/RunTest | Contains the Zoiper SDK dll and the additional library LAME.dll. |
| package/ZoiperWinForms | Contains all files for the Demo application as well as its settings, properties etc. |
| package/ZoiperWinForms.sln | The actual Demo project. To test Zoiper SDK 2.0, open, build and run the Demo application. |

## Setting up the Demo project

To be able to run the Zoiper C# Windows Example, you will need to include the zdk.net as a reference to the project and then to build it. 
By default zdk.net is not included in the example. 
If you still don't have the zdk.net library, please contact us on zoiper.com.

### Default configuration

By default, the Demo application uses the transport type you select from the GUI. 
STUN is enabled with these default STUN settings:
- Server: stun.zoiper.com
- Port: 4378
- Refresh period: 30s
- Enabled codecs: u-Law, Opus Wide and VP8

### Activation

You need an SDK activation to test the demo. Zoiper SDK 2.0 for .Net Framework offers both Online and Offline activation. 
#####Online Activation
To activate the demo online, you need an activation username and password from zoiper.com. Pass your activation credentials in the application to the StartSDK() method as illustrated below: 

```
//You will need to pass the activation credentials as certUserName and certPassword.
ctx.Activation.StartSDK("", certUserName, certPassword)
```
If the activation is successful, you will receive a result code “OK” from the StartSDK() method. You are now ready to test the Demo. 
In case the activation fails, the method will return a code with the reason for the failure. 

##### Offline Activation
Follow these steps to activate the demo offline:
1. Generate a certificate
2. Send it to register5@zoiper.com
3. You will receive an activation file via email
4. Put the activation file in the same directory as the project. Or pass it as a path to the file.

Beware! The first time you run the project and you call the activation, you must call the method to create an offline activation file - `CreateOfflineActivationFileSDK(path, certUserName, certPassword)` and pass the respective arguments. On the next start you just need to call the `StartSDK(path + "\\certificate", certUserName, certPassword)` method. 
Below, you can find a working example from the Demo application:
```
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

```

### Create and register your account

A complete example of the function that adds the user and its details is illustrated below:

```
public bool AddUser(Int32 transportType, String username, String password, String server, bool SRTP, bool ZRTP, bool FMTP , bool Privacy, bool Stun, bool Preconditions, bool RTCPFeedback, string protocol)
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
                ipher.Add(ZRTPCipherAlgorithm.cipher_aes1);

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
        AccEventHandler.OnAccountPushTokenReceived += Zoiper_OnAccountPushTokenReceived;

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

```

When the account is created, you can register it with the following function:

```
public bool RegisterUser()
{
	var result = Acc.RegisterAccount();
    return result.Code == ResultCode.Ok;
}

```

### Changing the project configuration

### Transport type

```
regCfg.SIP.Transport = (TransportType)transportType;

```

Possible values:  
- NA
- UDP
- TCP
- TLS

### STUN

```
if (Stun)
	{
    	regCfg.SIP.Stun = ctx.AccountProvider.CreateStunConfiguration();
        regCfg.SIP.Stun.STUNEnabled = true;
        regCfg.SIP.Stun.STUNServer = "stun.zoiper.com";
        regCfg.SIP.Stun.STUNPort = 3478;
        regCfg.SIP.Stun.STUNRefresh = 30000;
	}
```

### Changing the used codecs

```
List<AudioVideoCodecs> codecs = new List<AudioVideoCodecs>();
codecs.Add(AudioVideoCodecs.OPUS_WIDE);
codecs.Add(AudioVideoCodecs.PCMU);
// This is for the videocall
codecs.Add(AudioVideoCodecs.vp8);

account.MediaCodecs = codecs;
```

Possible values:
- NA
- G729
- GSM
- iLBC_20
- iLBC_30
- h264
- vp8
- h264_hwd
- SPEEX_NARROW
- SPEEX_WIDE
- SPEEX_ULTRA
- G726
- OPUS_NARROW
- OPUS_WIDE
- OPUS_SUPER
- OPUS_FULL
- AMR
- AMR_WB
- PCMU
- PCMA
- G722

## Create your Windows VoIP App

### Creating Zoiper SDK 2.0 Context in your application

To be able to use Zoiper SDK 2.0 in your application, you will have to add a reference to it in your project. Afterwards,  you should create a context of the SDK and then to initialize it.

```
private void CreateContext()
{
	ctx = new Context();

	ContextEventsHandler cthEvH = new ContextEventsHandler();
    cthEvH.OnContextActivationCompleted += ZDK_NET_OnContextActivationCompleted;
    cthEvH.OnContextSecureCertError += ZDK_NET_OnContextSecureCertError;
    ctx.SetStatusListener(cthEvH);
}
```

The actual start of the context is usually performed after receiving the callback for successful activation.

```
private void ZDK_NET_OnContextActivationCompleted(ZDK_NET.Context context, ZDK_NET.ActivationResult secureCert)
{
            if (OnZoiperEvent != null)
                OnZoiperEvent("OnActivationCompleted Build: " + secureCert.Build + " Reason:" + secureCert.Reason);

            if (secureCert.Status == ActivationStatus.Success)
            {
                ctx.Configuration.SIPPort = 44444;
                ctx.Configuration.RTPPort = 55555;

                ctx.StartContext();

                //Account account;
                //Call activeCall;
                

                ctx.VideoControls.SetFormat(352, 288, 6);
                //OnActivationSuccess(secureCert.Reason);
            }
            else
            {
                OnActivationError(secureCert.Reason);
            }
        }
```


### Zoiper SDK 2.0 initialization function example

The following example is from the Demo app. It illustrates how to include the combined initialization of Online and Offline activation

```
public bool Initialize(String path ,String certUserName, String certPassword)
{
	if (ctx == null)
    {
    	CreateContext();
	}

    string LogFile = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\zdk.net.log.txt";
    ctx.Logger.LogOpen(LogFile, null, LoggingLevel.Debug, 0);

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
```

## .Net Framework SDK Reference

You can find the API and method references [<span style=color:orange>here<span>](https://www.zoiper.com/documentation/desktop-c-sharp-windows-sdk/html/annotated.html).
