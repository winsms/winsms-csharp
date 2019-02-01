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
    /// ScheduledMessageResponse
    /// </summary>
    [DataContract]
    public partial class ScheduledMessageResponse :  IEquatable<ScheduledMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessageResponse" /> class.
        /// </summary>
        /// <param name="timeStamp">The date/time the request was processed, in the format YYYYMMDDhhmmssSSS.</param>
        /// <param name="version">The current version of the API of the endpoint that was called.</param>
        /// <param name="statusCode">The http status code returned - reflected in the body for convenience.</param>
        /// <param name="resultsOffset">The number of items skipped before the results were returned. This is the value specified in the ***offset*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 0. .</param>
        /// <param name="resultsLimit">The number of items returned in the results. This is the value specified in the ***limit*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 100. .</param>
        /// <param name="resultsTotalAvailable">The total number of results available for retrieval. The ***offset*** and ***limit*** properties specify which of the total available results have been returned. .</param>
        /// <param name="scheduledMessages">An array of ***scheduledMessage*** objects containing properties of each unsent scheduled message. .</param>
        public ScheduledMessageResponse(string timeStamp = default(string), string version = default(string), int? statusCode = default(int?), int? resultsOffset = default(int?), int? resultsLimit = default(int?), int? resultsTotalAvailable = default(int?), List<ScheduledMessage> scheduledMessages = default(List<ScheduledMessage>))
        {
            this.TimeStamp = timeStamp;
            this.Version = version;
            this.StatusCode = statusCode;
            this.ResultsOffset = resultsOffset;
            this.ResultsLimit = resultsLimit;
            this.ResultsTotalAvailable = resultsTotalAvailable;
            this.ScheduledMessages = scheduledMessages;
        }
        
        /// <summary>
        /// The date/time the request was processed, in the format YYYYMMDDhhmmssSSS
        /// </summary>
        /// <value>The date/time the request was processed, in the format YYYYMMDDhhmmssSSS</value>
        [DataMember(Name="timeStamp", EmitDefaultValue=false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// The current version of the API of the endpoint that was called
        /// </summary>
        /// <value>The current version of the API of the endpoint that was called</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The http status code returned - reflected in the body for convenience
        /// </summary>
        /// <value>The http status code returned - reflected in the body for convenience</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// The number of items skipped before the results were returned. This is the value specified in the ***offset*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 0. 
        /// </summary>
        /// <value>The number of items skipped before the results were returned. This is the value specified in the ***offset*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 0. </value>
        [DataMember(Name="resultsOffset", EmitDefaultValue=false)]
        public int? ResultsOffset { get; set; }

        /// <summary>
        /// The number of items returned in the results. This is the value specified in the ***limit*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 100. 
        /// </summary>
        /// <value>The number of items returned in the results. This is the value specified in the ***limit*** parameter sent to the endpoint. If the parameter was not specified, this defaults to 100. </value>
        [DataMember(Name="resultsLimit", EmitDefaultValue=false)]
        public int? ResultsLimit { get; set; }

        /// <summary>
        /// The total number of results available for retrieval. The ***offset*** and ***limit*** properties specify which of the total available results have been returned. 
        /// </summary>
        /// <value>The total number of results available for retrieval. The ***offset*** and ***limit*** properties specify which of the total available results have been returned. </value>
        [DataMember(Name="resultsTotalAvailable", EmitDefaultValue=false)]
        public int? ResultsTotalAvailable { get; set; }

        /// <summary>
        /// An array of ***scheduledMessage*** objects containing properties of each unsent scheduled message. 
        /// </summary>
        /// <value>An array of ***scheduledMessage*** objects containing properties of each unsent scheduled message. </value>
        [DataMember(Name="scheduledMessages", EmitDefaultValue=false)]
        public List<ScheduledMessage> ScheduledMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledMessageResponse {\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ResultsOffset: ").Append(ResultsOffset).Append("\n");
            sb.Append("  ResultsLimit: ").Append(ResultsLimit).Append("\n");
            sb.Append("  ResultsTotalAvailable: ").Append(ResultsTotalAvailable).Append("\n");
            sb.Append("  ScheduledMessages: ").Append(ScheduledMessages).Append("\n");
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
            return this.Equals(input as ScheduledMessageResponse);
        }

        /// <summary>
        /// Returns true if ScheduledMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeStamp == input.TimeStamp ||
                    (this.TimeStamp != null &&
                    this.TimeStamp.Equals(input.TimeStamp))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.ResultsOffset == input.ResultsOffset ||
                    (this.ResultsOffset != null &&
                    this.ResultsOffset.Equals(input.ResultsOffset))
                ) && 
                (
                    this.ResultsLimit == input.ResultsLimit ||
                    (this.ResultsLimit != null &&
                    this.ResultsLimit.Equals(input.ResultsLimit))
                ) && 
                (
                    this.ResultsTotalAvailable == input.ResultsTotalAvailable ||
                    (this.ResultsTotalAvailable != null &&
                    this.ResultsTotalAvailable.Equals(input.ResultsTotalAvailable))
                ) && 
                (
                    this.ScheduledMessages == input.ScheduledMessages ||
                    this.ScheduledMessages != null &&
                    this.ScheduledMessages.SequenceEqual(input.ScheduledMessages)
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
                if (this.TimeStamp != null)
                    hashCode = hashCode * 59 + this.TimeStamp.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ResultsOffset != null)
                    hashCode = hashCode * 59 + this.ResultsOffset.GetHashCode();
                if (this.ResultsLimit != null)
                    hashCode = hashCode * 59 + this.ResultsLimit.GetHashCode();
                if (this.ResultsTotalAvailable != null)
                    hashCode = hashCode * 59 + this.ResultsTotalAvailable.GetHashCode();
                if (this.ScheduledMessages != null)
                    hashCode = hashCode * 59 + this.ScheduledMessages.GetHashCode();
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
