# winsms.Model.MessageRecipientResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientMessageId** | **string** | If the optional ***clientMessageId*** value was specified in the recipient object for the recipient, it will be returned here. If not, ***clientMessageId*** will be **null**.  | [optional] 
**MobileNumber** | **string** | The mobile number specified as the ***mobileNumber*** value of the recipient object of the request.  | [optional] 
**Accepted** | **bool?** | A boolean value indicating whether the API accepted the recipient for SMS delivery. This will be **false** If you have insufficient credits or the recipient mobile number supplied is not valid.  | [optional] 
**AcceptError** | **string** | If the ***accepted*** value is **false**, this will contain the reason that delivery to the recipient was declined by the API. If the recipient was accepted, this value will be blank.  | [optional] 
**ApiMessageId** | **int?** | The WinSMS Message Id assigned to the specific message recipient. This Id can be used to obtain the status of the message, and to delete the message if it was scheduled. If the API did not accept the recipient for delivery, the value will be **null**.  | [optional] 
**ScheduledTime** | **int?** | The date and time that the message was scheduled for delivery to the recipient.  If no ***scheduledTime*** value was specified in the request, or the recipient was not accepted for delivery, this value will be **null**.  | [optional] 
**CreditCost** | **double?** | The number of credits deducted from your account for the SMS to this recipient.  The credit cost is based on the destination country of the recipient and the length (number of segments) of the message.  This credit cost will be reimbursed if the message is scheduled and subsequently deleted.  If the recipient is not accepted for delivery, the ***creditCost*** value will be **null**.  | [optional] 
**NewCreditBalance** | **double?** | The number of WinSMS credits remaining in your account after processing this recipient.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

