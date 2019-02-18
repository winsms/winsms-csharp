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
    /// ErrorDetails
    /// </summary>
    [DataContract]
    public partial class ErrorDetails :  IEquatable<ErrorDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
        /// </summary>
        /// <param name="timeStamp">The date/time the request was processed, in the format YYYYMMDDhhmmssSSS .</param>
        /// <param name="version">The current version of the API of the endpoint that was called .</param>
        /// <param name="statusCode">The http status code returned - reflected in the body for convenience .</param>
        /// <param name="errorMessage">A plain text description of the error that occurred, and possible solutions if available.  .</param>
        public ErrorDetails(string timeStamp = default(string), string version = default(string), int? statusCode = default(int?), string errorMessage = default(string))
        {
            this.TimeStamp = timeStamp;
            this.Version = version;
            this.StatusCode = statusCode;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// The date/time the request was processed, in the format YYYYMMDDhhmmssSSS 
        /// </summary>
        /// <value>The date/time the request was processed, in the format YYYYMMDDhhmmssSSS </value>
        [DataMember(Name="timeStamp", EmitDefaultValue=false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// The current version of the API of the endpoint that was called 
        /// </summary>
        /// <value>The current version of the API of the endpoint that was called </value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The http status code returned - reflected in the body for convenience 
        /// </summary>
        /// <value>The http status code returned - reflected in the body for convenience </value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// A plain text description of the error that occurred, and possible solutions if available.  
        /// </summary>
        /// <value>A plain text description of the error that occurred, and possible solutions if available.  </value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorDetails {\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as ErrorDetails);
        }

        /// <summary>
        /// Returns true if ErrorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetails input)
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
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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