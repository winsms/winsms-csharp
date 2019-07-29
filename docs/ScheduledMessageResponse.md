# IO.Swagger.Model.ScheduledMessageResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeStamp** | **string** | The date/time the request was processed, in the format YYYYMMDDhhmmssSSS | [optional] 
**Version** | **string** | The current version of the API of the endpoint that was called | [optional] 
**StatusCode** | **int?** | The http status code returned - reflected in the body for convenience | [optional] 
**ResultsOffset** | **int?** | The number of items skipped before the results were returned. This is the value specified in the ***offset*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 0.  | [optional] 
**ResultsLimit** | **int?** | The number of items returned in the results. This is the value specified in the ***limit*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 100.  | [optional] 
**ResultsTotalAvailable** | **int?** | The total number of results available for retrieval. The ***offset*** and ***limit*** properties specify which of the total available results have been returned.  | [optional] 
**ScheduledMessages** | [**List&lt;ScheduledMessage&gt;**](ScheduledMessage.md) | An array of ***scheduledMessage*** objects containing properties of each unsent scheduled message.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

