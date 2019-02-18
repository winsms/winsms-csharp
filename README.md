# WinSMS - C# Library

- API version: 1.0.0
- SDK version: 1.0.0

For more information, please visit [http://support.winsms.co.za/](http://support.winsms.co.za/)
> # DISCLAIMER:
> The SDK is provided as a guideline to accessing the WinSMS API. The code is provided "as is" without any guarantees. Depending on your environment, the SDK may not work "out-of-the-box", therefore it is expected that you have sufficient technical knowledge and development skills to address any coding issues that may arise from using this SDK.

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using winsms.Api;
using winsms.Client;
using winsms.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out winsms.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("AUTHORIZATION", "Bearer");

            var apiInstance = new CreditsApi();

            try
            {
                // Get your current WinSMS credit balance
                CreditBalanceResponse result = apiInstance.GetCreditBalance();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditsApi.GetCreditBalance: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://www.winsms.co.za/api/rest/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CreditsApi* | [**GetCreditBalance**](docs/CreditsApi.md#getcreditbalance) | **GET** /credits/balance | Get your current WinSMS credit balance
*CreditsApi* | [**TransferCredits**](docs/CreditsApi.md#transfercredits) | **POST** /credits/transfer | Transfer credits between main and sub accounts.
*ShortcodeApi* | [**GetShortCodeMessages**](docs/ShortcodeApi.md#getshortcodemessages) | **GET** /shortcode/incoming | Get a list of incoming short/long code messages 
*SmsApi* | [**DeleteScheduledMessages**](docs/SmsApi.md#deletescheduledmessages) | **POST** /sms/scheduled/delete | Delete scheduled SMS messages and refund credits
*SmsApi* | [**GetIncomingMessages**](docs/SmsApi.md#getincomingmessages) | **GET** /sms/incoming | Get a list of incoming SMS messages
*SmsApi* | [**GetOptoutMessages**](docs/SmsApi.md#getoptoutmessages) | **GET** /sms/incoming/optout | Get a list of incoming opt-out SMS messages
*SmsApi* | [**GetScheduledMessages**](docs/SmsApi.md#getscheduledmessages) | **GET** /sms/scheduled | Get a list of scheduled SMS messages
*SmsApi* | [**SmsSend**](docs/SmsApi.md#smssend) | **POST** /sms/outgoing/send | Send SMS messages
*SmsApi* | [**SmsStatus**](docs/SmsApi.md#smsstatus) | **POST** /sms/outgoing/status | Get SMS delivery statuses
*SubaccountsApi* | [**GetSubAccounts**](docs/SubaccountsApi.md#getsubaccounts) | **GET** /subaccounts | Get a list of all Sub Accounts.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CreditBalanceResponse](docs/CreditBalanceResponse.md)
 - [Model.CreditTransferDetails](docs/CreditTransferDetails.md)
 - [Model.CreditTransferResponse](docs/CreditTransferResponse.md)
 - [Model.DeleteScheduledResponse](docs/DeleteScheduledResponse.md)
 - [Model.DeletedMessageStatus](docs/DeletedMessageStatus.md)
 - [Model.ErrorDetails](docs/ErrorDetails.md)
 - [Model.IncomingMessage](docs/IncomingMessage.md)
 - [Model.IncomingMessageResponse](docs/IncomingMessageResponse.md)
 - [Model.IncomingOptoutMessage](docs/IncomingOptoutMessage.md)
 - [Model.MessageRecipientDetails](docs/MessageRecipientDetails.md)
 - [Model.MessageRecipientResponse](docs/MessageRecipientResponse.md)
 - [Model.MessageStatus](docs/MessageStatus.md)
 - [Model.MessageStatusResponse](docs/MessageStatusResponse.md)
 - [Model.NewMessageDetails](docs/NewMessageDetails.md)
 - [Model.NewMessageResponse](docs/NewMessageResponse.md)
 - [Model.OptoutMessageResponse](docs/OptoutMessageResponse.md)
 - [Model.ScheduledMessage](docs/ScheduledMessage.md)
 - [Model.ScheduledMessageResponse](docs/ScheduledMessageResponse.md)
 - [Model.ShortcodeMessage](docs/ShortcodeMessage.md)
 - [Model.ShortcodeMessageResponse](docs/ShortcodeMessageResponse.md)
 - [Model.SubAccount](docs/SubAccount.md)
 - [Model.SubAccountsResponse](docs/SubAccountsResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="APIKeyHeader"></a>
### APIKeyHeader

- **Type**: API key
- **API key parameter name**: AUTHORIZATION
- **Location**: HTTP header

