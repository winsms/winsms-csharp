# winsms.Api.ShortcodeApi

All URIs are relative to *https://www.winsms.co.za/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetShortCodeMessages**](ShortcodeApi.md#getshortcodemessages) | **GET** /shortcode/incoming | Get a list of incoming short/long code messages 


<a name="getshortcodemessages"></a>
# **GetShortCodeMessages**
> ShortcodeMessageResponse GetShortCodeMessages (int? offset = null, int? limit = null)

Get a list of incoming short/long code messages 

***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 

### Example
```csharp
using System;
using System.Diagnostics;
using winsms.Api;
using winsms.Client;
using winsms.Model;

namespace Example
{
    public class GetShortCodeMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new ShortcodeApi();
            var offset = 56;  // int? | ***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional)  (default to 0)
            var limit = 56;  // int? | ***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional)  (default to 100)

            try
            {
                // Get a list of incoming short/long code messages 
                ShortcodeMessageResponse result = apiInstance.GetShortCodeMessages(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShortcodeApi.GetShortCodeMessages: " + e.Message );
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

[**ShortcodeMessageResponse**](ShortcodeMessageResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

