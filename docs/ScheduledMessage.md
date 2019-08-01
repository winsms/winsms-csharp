# winsms.Model.ScheduledMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiMessageId** | **int?** | The WinSMS API Message Id identifying the SMS message. | [optional] 
**MobileNumber** | **string** | The mobile number of the recipient of the SMS message, using the international E164 (without the plus) format | [optional] 
**SubmitTime** | **string** | The date and time the message was originally submitted for scheduled delivery, in the format YYYYMMDDHHmm. | [optional] 
**ScheduledSendTime** | **string** | The date and time the message is scheduled to be delivered to the recipient, in the format YYYYMMDDHHmm. | [optional] 
**CreditCost** | **double?** | The number of credits deducted from your account for the SMS to this recipient.  This is the number of credits that will be refunded if you delete this scheduled message.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

