# IO.Swagger.Model.DeletedMessageStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiMessageId** | **int?** | The WinSMS API Message Id identifying the SMS message.  | [optional] 
**MobileNumber** | **string** | The mobile number of the recipient of the SMS message, using the international E164 (without the plus) format  | [optional] 
**Deleted** | **bool?** | A boolean value indicating whether a scheduled SMS message was successfully deleted  | [optional] 
**DeleteError** | **string** | If the ***deleted*** value is false, this will contain an error code indicating the reason for the failure. If the scheduled SMS message was successfully deleted, this value will be blank.  | [optional] 
**CreditCost** | **double?** | The number of credits refunded to your account after deleting the scheduled message.  If the deletion was unsuccessful, this value will be 0.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

