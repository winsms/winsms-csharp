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
    /// NewMessageDetails
    /// </summary>
    [DataContract]
    public partial class NewMessageDetails :  IEquatable<NewMessageDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewMessageDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewMessageDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewMessageDetails" /> class.
        /// </summary>
        /// <param name="message">The SMS text to be sent. (required).</param>
        /// <param name="recipients">An array of messageRecipientDetails objects. (required).</param>
        /// <param name="scheduledTime">***Optional*** - The date and time that an SMS should be delivered. If not specified, or is set for a date/time prior to the current date/time, the SMS message will be sent immediately.  If specified, this value should have the format YYYYMMDDHHmm. .</param>
        /// <param name="maxSegments">***Optional*** - The maximum [GSM Encoded segment count](\&quot;https://support.winsms.co.za/rest/GSM\&quot;) that the message is allowed to utilise.  This defaults to 1, allowing for a maximum GSM Encoded message length of 160 characters.  The maximum value is 6, which allows for a GSM Encoded message length of 918 characters.  If you intend to send a message longer than 160 characters, this value should be specified. .</param>
        public NewMessageDetails(string message = default(string), List<MessageRecipientDetails> recipients = default(List<MessageRecipientDetails>), int? scheduledTime = default(int?), int? maxSegments = default(int?))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for NewMessageDetails and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for NewMessageDetails and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
            this.ScheduledTime = scheduledTime;
            this.MaxSegments = maxSegments;
        }
        
        /// <summary>
        /// The SMS text to be sent.
        /// </summary>
        /// <value>The SMS text to be sent.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// An array of messageRecipientDetails objects.
        /// </summary>
        /// <value>An array of messageRecipientDetails objects.</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<MessageRecipientDetails> Recipients { get; set; }

        /// <summary>
        /// ***Optional*** - The date and time that an SMS should be delivered. If not specified, or is set for a date/time prior to the current date/time, the SMS message will be sent immediately.  If specified, this value should have the format YYYYMMDDHHmm. 
        /// </summary>
        /// <value>***Optional*** - The date and time that an SMS should be delivered. If not specified, or is set for a date/time prior to the current date/time, the SMS message will be sent immediately.  If specified, this value should have the format YYYYMMDDHHmm. </value>
        [DataMember(Name="scheduledTime", EmitDefaultValue=false)]
        public int? ScheduledTime { get; set; }

        /// <summary>
        /// ***Optional*** - The maximum [GSM Encoded segment count](\&quot;https://support.winsms.co.za/rest/GSM\&quot;) that the message is allowed to utilise.  This defaults to 1, allowing for a maximum GSM Encoded message length of 160 characters.  The maximum value is 6, which allows for a GSM Encoded message length of 918 characters.  If you intend to send a message longer than 160 characters, this value should be specified. 
        /// </summary>
        /// <value>***Optional*** - The maximum [GSM Encoded segment count](\&quot;https://support.winsms.co.za/rest/GSM\&quot;) that the message is allowed to utilise.  This defaults to 1, allowing for a maximum GSM Encoded message length of 160 characters.  The maximum value is 6, which allows for a GSM Encoded message length of 918 characters.  If you intend to send a message longer than 160 characters, this value should be specified. </value>
        [DataMember(Name="maxSegments", EmitDefaultValue=false)]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewMessageDetails {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  ScheduledTime: ").Append(ScheduledTime).Append("\n");
            sb.Append("  MaxSegments: ").Append(MaxSegments).Append("\n");
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
            return this.Equals(input as NewMessageDetails);
        }

        /// <summary>
        /// Returns true if NewMessageDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of NewMessageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewMessageDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.ScheduledTime == input.ScheduledTime ||
                    (this.ScheduledTime != null &&
                    this.ScheduledTime.Equals(input.ScheduledTime))
                ) && 
                (
                    this.MaxSegments == input.MaxSegments ||
                    (this.MaxSegments != null &&
                    this.MaxSegments.Equals(input.MaxSegments))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.ScheduledTime != null)
                    hashCode = hashCode * 59 + this.ScheduledTime.GetHashCode();
                if (this.MaxSegments != null)
                    hashCode = hashCode * 59 + this.MaxSegments.GetHashCode();
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
            // MaxSegments (int?) maximum
            if(this.MaxSegments > (int?)6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxSegments, must be a value less than or equal to 6.", new [] { "MaxSegments" });
            }

            // MaxSegments (int?) minimum
            if(this.MaxSegments < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxSegments, must be a value greater than or equal to 1.", new [] { "MaxSegments" });
            }

            yield break;
        }
    }

}
