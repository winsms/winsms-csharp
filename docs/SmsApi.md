# winsms.Api.SmsApi

All URIs are relative to *https://www.winsms.co.za/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteScheduledMessages**](SmsApi.md#deletescheduledmessages) | **POST** /sms/scheduled/delete | Delete scheduled SMS messages and refund credits
[**GetIncomingMessages**](SmsApi.md#getincomingmessages) | **GET** /sms/incoming | Get a list of incoming SMS messages
[**GetOptoutMessages**](SmsApi.md#getoptoutmessages) | **GET** /sms/incoming/optout | Get a list of incoming opt-out SMS messages
[**GetScheduledMessages**](SmsApi.md#getscheduledmessages) | **GET** /sms/scheduled | Get a list of scheduled SMS messages
[**SmsSend**](SmsApi.md#smssend) | **POST** /sms/outgoing/send | Send SMS messages
[**SmsStatus**](SmsApi.md#smsstatus) | **POST** /sms/outgoing/status | Get SMS delivery statuses


<a name="deletescheduledmessages"></a>
# **DeleteScheduledMessages**
> DeleteScheduledResponse DeleteScheduledMessages (List<int?> messageDeleteRequest)

Delete scheduled SMS messages and refund credits

Delete a list of previously scheduled SMS messages that have not yet been sent.  Credits originally deducted for each SMS message will be refunded to your account upon successful deletion. 

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class DeleteScheduledMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SmsApi();
            var messageDeleteRequest = ;  // List<int?> | An array of WinSMS API Ids received after submitting scheduled messages to the ***_/sms/outgoing/send*** endpoint.<br> A maximum of 1000 API Ids can be supplied in a single request. 

            try
            {
                // Delete scheduled SMS messages and refund credits
                DeleteScheduledResponse result = apiInstance.DeleteScheduledMessages(messageDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.DeleteScheduledMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageDeleteRequest** | **List&lt;int?&gt;**| An array of WinSMS API Ids received after submitting scheduled messages to the ***_/sms/outgoing/send*** endpoint.&lt;br&gt; A maximum of 1000 API Ids can be supplied in a single request.  | 

### Return type

[**DeleteScheduledResponse**](DeleteScheduledResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getincomingmessages"></a>
# **GetIncomingMessages**
> IncomingMessageResponse GetIncomingMessages (int? offset = null, int? limit = null)

Get a list of incoming SMS messages

Get a list of all incoming SMS messages received by the account.  Only the first 100 incoming messages will be returned if no ***offset*** and ***limit*** parameters are specified. 

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class GetIncomingMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SmsApi();
            var offset = 56;  // int? | ***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional)  (default to 0)
            var limit = 56;  // int? | ***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional)  (default to 100)

            try
            {
                // Get a list of incoming SMS messages
                IncomingMessageResponse result = apiInstance.GetIncomingMessages(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.GetIncomingMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| ***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  | [optional] [default to 0]
 **limit** | **int?**| ***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  | [optional] [default to 100]

### Return type

[**IncomingMessageResponse**](IncomingMessageResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoptoutmessages"></a>
# **GetOptoutMessages**
> OptoutMessageResponse GetOptoutMessages ()

Get a list of incoming opt-out SMS messages

Get a list of all opt-out SMS messages received by the account, as well as all manually added opt-out numbers.<br>

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class GetOptoutMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SmsApi();

            try
            {
                // Get a list of incoming opt-out SMS messages
                OptoutMessageResponse result = apiInstance.GetOptoutMessages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.GetOptoutMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OptoutMessageResponse**](OptoutMessageResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledmessages"></a>
# **GetScheduledMessages**
> ScheduledMessageResponse GetScheduledMessages (int? offset = null, int? limit = null)

Get a list of scheduled SMS messages

Get a list of all scheduled SMS messages that have not yet been sent.  Only the first 100 scheduled messages will be returned if no ***offset*** and ***limit*** parameters are specified. 

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class GetScheduledMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SmsApi();
            var offset = 56;  // int? | ***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional)  (default to 0)
            var limit = 56;  // int? | ***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional)  (default to 100)

            try
            {
                // Get a list of scheduled SMS messages
                ScheduledMessageResponse result = apiInstance.GetScheduledMessages(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.GetScheduledMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| ***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  | [optional] [default to 0]
 **limit** | **int?**| ***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  | [optional] [default to 100]

### Return type

[**ScheduledMessageResponse**](ScheduledMessageResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smssend"></a>
# **SmsSend**
> NewMessageResponse SmsSend (NewMessageDetails newMessageDetails)

Send SMS messages

Submit 1 or more SMS messages to be sent by WinSMS. Maximum 1000 recipients per request.  The SMS message text can be a maximum of 918 characters long. If you are submitting a message longer than 160 characters, you should change the value of ***maxSegments***. 

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class SmsSendExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SmsApi();
            var newMessageDetails = new NewMessageDetails(); // NewMessageDetails | The message, recipients and delivery options of an SMS message to be sent. 

            try
            {
                // Send SMS messages
                NewMessageResponse result = apiInstance.SmsSend(newMessageDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.SmsSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newMessageDetails** | [**NewMessageDetails**](NewMessageDetails.md)| The message, recipients and delivery options of an SMS message to be sent.  | 

### Return type

[**NewMessageResponse**](NewMessageResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsstatus"></a>
# **SmsStatus**
> MessageStatusResponse SmsStatus (List<int?> messageStatusRequest)

Get SMS delivery statuses

Get a list of previously submitted SMS message delivery statuses.  Post an array of API Message Ids received from the ***_/sms/outgoing/send*** endpoint. 

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class SmsStatusExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SmsApi();
            var messageStatusRequest = ;  // List<int?> | An array of WinSMS API Ids received after submitting messages to the ***_/sms/outgoing/send*** endpoint.  A maximum of 1000 API Ids can be supplied in a single request. 

            try
            {
                // Get SMS delivery statuses
                MessageStatusResponse result = apiInstance.SmsStatus(messageStatusRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.SmsStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageStatusRequest** | **List&lt;int?&gt;**| An array of WinSMS API Ids received after submitting messages to the ***_/sms/outgoing/send*** endpoint.  A maximum of 1000 API Ids can be supplied in a single request.  | 

### Return type

[**MessageStatusResponse**](MessageStatusResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

