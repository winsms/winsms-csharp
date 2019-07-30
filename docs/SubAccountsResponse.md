# winsms.Model.SubAccountsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeStamp** | **string** | The date/time the request was processed, in the format YYYYMMDDhhmmssSSS | [optional] 
**Version** | **string** | The current version of the API of the endpoint that was called | [optional] 
**StatusCode** | **int?** | The http status code returned - reflected in the body for convenience | [optional] 
**SubAccounts** | [**List&lt;SubAccount&gt;**](SubAccount.md) | An array of ***subAccount*** objects containing properties of each Sub Account owned by the Main Account.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

