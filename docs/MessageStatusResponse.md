# winsms.Model.MessageStatusResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeStamp** | **string** | The date/time the request was processed, in the format YYYYMMDDhhmmssSSS | [optional] 
**Version** | **string** | The current version of the API of the endpoint that was called | [optional] 
**StatusCode** | **int?** | The http status code returned - reflected in the body for convenience | [optional] 
**MessageStatuses** | [**List&lt;MessageStatus&gt;**](MessageStatus.md) | An array of ***messageStatus*** objects detailing the delivery status of each message  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

