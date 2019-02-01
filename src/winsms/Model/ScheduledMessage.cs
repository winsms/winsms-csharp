/* 
 * WINSMS
 *
 * WinSMS RESTful API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@winsms.co.za
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = winsms.Client.SwaggerDateConverter;

namespace winsms.Model
{
    /// <summary>
    /// ScheduledMessage
    /// </summary>
    [DataContract]
    public partial class ScheduledMessage :  IEquatable<ScheduledMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessage" /> class.
        /// </summary>
        /// <param name="apiMessageId">The WinSMS API Message Id identifying the SMS message..</param>
        /// <param name="mobileNumber">The mobile number of the recipient of the SMS message, using the international E164 (without the plus) format.</param>
        /// <param name="submitTime">The date and time the message was originally submitted for scheduled delivery, in the format YYYYMMDDHHmm..</param>
        /// <param name="scheduledSendTime">The date and time the message is scheduled to be delivered to the recipient, in the format YYYYMMDDHHmm..</param>
        /// <param name="creditCost">The number of credits deducted from your account for the SMS to this recipient.  This is the number of credits that will be refunded if you delete this scheduled message. .</param>
        public ScheduledMessage(int? apiMessageId = default(int?), string mobileNumber = default(string), int? submitTime = default(int?), int? scheduledSendTime = default(int?), double? creditCost = default(double?))
        {
            this.ApiMessageId = apiMessageId;
            this.MobileNumber = mobileNumber;
            this.SubmitTime = submitTime;
            this.ScheduledSendTime = scheduledSendTime;
            this.CreditCost = creditCost;
        }
        
        /// <summary>
        /// The WinSMS API Message Id identifying the SMS message.
        /// </summary>
        /// <value>The WinSMS API Message Id identifying the SMS message.</value>
        [DataMember(Name="apiMessageId", EmitDefaultValue=false)]
        public int? ApiMessageId { get; set; }

        /// <summary>
        /// The mobile number of the recipient of the SMS message, using the international E164 (without the plus) format
        /// </summary>
        /// <value>The mobile number of the recipient of the SMS message, using the international E164 (without the plus) format</value>
        [DataMember(Name="mobileNumber", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// The date and time the message was originally submitted for scheduled delivery, in the format YYYYMMDDHHmm.
        /// </summary>
        /// <value>The date and time the message was originally submitted for scheduled delivery, in the format YYYYMMDDHHmm.</value>
        [DataMember(Name="submitTime", EmitDefaultValue=false)]
        public int? SubmitTime { get; set; }

        /// <summary>
        /// The date and time the message is scheduled to be delivered to the recipient, in the format YYYYMMDDHHmm.
        /// </summary>
        /// <value>The date and time the message is scheduled to be delivered to the recipient, in the format YYYYMMDDHHmm.</value>
        [DataMember(Name="scheduledSendTime", EmitDefaultValue=false)]
        public int? ScheduledSendTime { get; set; }

        /// <summary>
        /// The number of credits deducted from your account for the SMS to this recipient.  This is the number of credits that will be refunded if you delete this scheduled message. 
        /// </summary>
        /// <value>The number of credits deducted from your account for the SMS to this recipient.  This is the number of credits that will be refunded if you delete this scheduled message. </value>
        [DataMember(Name="creditCost", EmitDefaultValue=false)]
        public double? CreditCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledMessage {\n");
            sb.Append("  ApiMessageId: ").Append(ApiMessageId).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  SubmitTime: ").Append(SubmitTime).Append("\n");
            sb.Append("  ScheduledSendTime: ").Append(ScheduledSendTime).Append("\n");
            sb.Append("  CreditCost: ").Append(CreditCost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledMessage);
        }

        /// <summary>
        /// Returns true if ScheduledMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiMessageId == input.ApiMessageId ||
                    (this.ApiMessageId != null &&
                    this.ApiMessageId.Equals(input.ApiMessageId))
                ) && 
                (
                    this.MobileNumber == input.MobileNumber ||
                    (this.MobileNumber != null &&
                    this.MobileNumber.Equals(input.MobileNumber))
                ) && 
                (
                    this.SubmitTime == input.SubmitTime ||
                    (this.SubmitTime != null &&
                    this.SubmitTime.Equals(input.SubmitTime))
                ) && 
                (
                    this.ScheduledSendTime == input.ScheduledSendTime ||
                    (this.ScheduledSendTime != null &&
                    this.ScheduledSendTime.Equals(input.ScheduledSendTime))
                ) && 
                (
                    this.CreditCost == input.CreditCost ||
                    (this.CreditCost != null &&
                    this.CreditCost.Equals(input.CreditCost))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApiMessageId != null)
                    hashCode = hashCode * 59 + this.ApiMessageId.GetHashCode();
                if (this.MobileNumber != null)
                    hashCode = hashCode * 59 + this.MobileNumber.GetHashCode();
                if (this.SubmitTime != null)
                    hashCode = hashCode * 59 + this.SubmitTime.GetHashCode();
                if (this.ScheduledSendTime != null)
                    hashCode = hashCode * 59 + this.ScheduledSendTime.GetHashCode();
                if (this.CreditCost != null)
                    hashCode = hashCode * 59 + this.CreditCost.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
