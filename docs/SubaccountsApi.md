# IO.Swagger.Api.SubaccountsApi

All URIs are relative to *https://www.winsms.co.za/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubAccounts**](SubaccountsApi.md#getsubaccounts) | **GET** /subaccounts | Get a list of all Sub Accounts.


<a name="getsubaccounts"></a>
# **GetSubAccounts**
> SubAccountsResponse GetSubAccounts ()

Get a list of all Sub Accounts.

Get a list of all the Sub Accounts owned by the Main Account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubAccountsExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new SubaccountsApi();

            try
            {
                // Get a list of all Sub Accounts.
                SubAccountsResponse result = apiInstance.GetSubAccounts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountsApi.GetSubAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SubAccountsResponse**](SubAccountsResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

