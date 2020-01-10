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
    /// HostsResponse
    /// </summary>
    [DataContract]
    public partial class HostsResponse :  IEquatable<HostsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HostsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostsResponse" /> class.
        /// </summary>
        /// <param name="hosts">hosts (required).</param>
        public HostsResponse(List<Host> hosts = default(List<Host>))
        {
            // to ensure "hosts" is required (not null)
            if (hosts == null)
            {
                throw new InvalidDataException("hosts is a required property for HostsResponse and cannot be null");
            }
            else
            {
                this.Hosts = hosts;
            }

        }
        
        /// <summary>
        /// Gets or Sets Hosts
        /// </summary>
        [DataMember(Name="hosts", EmitDefaultValue=false)]
        public List<Host> Hosts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostsResponse {\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
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
            return this.Equals(input as HostsResponse);
        }

        /// <summary>
        /// Returns true if HostsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HostsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
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
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
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
