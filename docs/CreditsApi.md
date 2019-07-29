# IO.Swagger.Api.CreditsApi

All URIs are relative to *https://www.winsms.co.za/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCreditBalance**](CreditsApi.md#getcreditbalance) | **GET** /credits/balance | Get your current WinSMS credit balance
[**TransferCredits**](CreditsApi.md#transfercredits) | **POST** /credits/transfer | Transfer credits between main and sub accounts.


<a name="getcreditbalance"></a>
# **GetCreditBalance**
> CreditBalanceResponse GetCreditBalance ()

Get your current WinSMS credit balance

Get the current remaining credit balance for the account.  ***Note*** - The credit balance is expressed as a value with a single decimal place. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditBalanceExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

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

### Parameters
This endpoint does not need any parameter.

### Return type

[**CreditBalanceResponse**](CreditBalanceResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfercredits"></a>
# **TransferCredits**
> CreditTransferResponse TransferCredits (CreditTransferDetails creditTransferDetails)

Transfer credits between main and sub accounts.

Transfer credits between accounts. - From Main account to Sub account.  - From Sub account to Main account.  - From Sub account to another Sub account.  Your WinSMS account number and sub account number/s can be obtained by logging in to the WinSMS Client Zone (www.winsms.co.za/cz) with the main account's credentials.  The main account number is on the home tab and the sub account numbers are under the sub accounts tab.  Account numbers should be submitted as integers. Do not add the 'W' prefix. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransferCreditsExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.AddApiKey("AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("AUTHORIZATION", "Bearer");

            var apiInstance = new CreditsApi();
            var creditTransferDetails = new CreditTransferDetails(); // CreditTransferDetails | The details of the credit transfer. Sender account number, recipient account number, and number of credits to transfer.

            try
            {
                // Transfer credits between main and sub accounts.
                CreditTransferResponse result = apiInstance.TransferCredits(creditTransferDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditsApi.TransferCredits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creditTransferDetails** | [**CreditTransferDetails**](CreditTransferDetails.md)| The details of the credit transfer. Sender account number, recipient account number, and number of credits to transfer. | 

### Return type

[**CreditTransferResponse**](CreditTransferResponse.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

