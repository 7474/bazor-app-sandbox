/* 
 * Makerel API
 *
 * This is part of Makerel API.
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Koudenpa.Mackerel.Api.Client.OpenAPIDateConverter;

namespace Koudenpa.Mackerel.Api.Model
{
    /// <summary>
    /// Alert
    /// </summary>
    [DataContract]
    public partial class Alert :  IEquatable<Alert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Alert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="monitorId">monitorId (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="hostId">hostId.</param>
        /// <param name="value">value.</param>
        /// <param name="message">message.</param>
        /// <param name="reason">reason.</param>
        /// <param name="openedAt">openedAt (required).</param>
        /// <param name="closedAt">closedAt.</param>
        public Alert(string id = default(string), string status = default(string), string monitorId = default(string), string type = default(string), string hostId = default(string), decimal value = default(decimal), string message = default(string), string reason = default(string), int openedAt = default(int), int closedAt = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Alert and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Alert and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "monitorId" is required (not null)
            if (monitorId == null)
            {
                throw new InvalidDataException("monitorId is a required property for Alert and cannot be null");
            }
            else
            {
                this.MonitorId = monitorId;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Alert and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "openedAt" is required (not null)
            if (openedAt == null)
            {
                throw new InvalidDataException("openedAt is a required property for Alert and cannot be null");
            }
            else
            {
                this.OpenedAt = openedAt;
            }

            this.HostId = hostId;
            this.Value = value;
            this.Message = message;
            this.Reason = reason;
            this.ClosedAt = closedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets MonitorId
        /// </summary>
        [DataMember(Name="monitorId", EmitDefaultValue=false)]
        public string MonitorId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets HostId
        /// </summary>
        [DataMember(Name="hostId", EmitDefaultValue=false)]
        public string HostId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets OpenedAt
        /// </summary>
        [DataMember(Name="openedAt", EmitDefaultValue=false)]
        public int OpenedAt { get; set; }

        /// <summary>
        /// Gets or Sets ClosedAt
        /// </summary>
        [DataMember(Name="closedAt", EmitDefaultValue=false)]
        public int ClosedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Alert {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MonitorId: ").Append(MonitorId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HostId: ").Append(HostId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  OpenedAt: ").Append(OpenedAt).Append("\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
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
            return this.Equals(input as Alert);
        }

        /// <summary>
        /// Returns true if Alert instances are equal
        /// </summary>
        /// <param name="input">Instance of Alert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Alert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MonitorId == input.MonitorId ||
                    (this.MonitorId != null &&
                    this.MonitorId.Equals(input.MonitorId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.OpenedAt == input.OpenedAt ||
                    this.OpenedAt.Equals(input.OpenedAt)
                ) && 
                (
                    this.ClosedAt == input.ClosedAt ||
                    this.ClosedAt.Equals(input.ClosedAt)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MonitorId != null)
                    hashCode = hashCode * 59 + this.MonitorId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                hashCode = hashCode * 59 + this.OpenedAt.GetHashCode();
                hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
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