/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AppleReq
    /// </summary>
    [DataContract(Name = "appleReq")]
    public partial class AppleReq : IEquatable<AppleReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppleReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleReq" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar (required).</param>
        /// <param name="mealy">mealy.</param>
        public AppleReq(string cultivar = default(string), bool mealy = default(bool))
        {
            // to ensure "cultivar" is required (not null)
            if (cultivar == null)
            {
                throw new ArgumentNullException("cultivar is a required property for AppleReq and cannot be null");
            }
            this._Cultivar = cultivar;
            this._Mealy = mealy;
            if (this.Mealy != null)
            {
                this._flagMealy = true;
            }
        }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [DataMember(Name = "cultivar", IsRequired = true, EmitDefaultValue = true)]
        public string Cultivar
        {
            get{ return _Cultivar;}
            set
            {
                _Cultivar = value;
                _flagCultivar = true;
            }
        }
        private string _Cultivar;
        private bool _flagCultivar;

        /// <summary>
        /// Returns false as Cultivar should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCultivar()
        {
            return _flagCultivar;
        }
        /// <summary>
        /// Gets or Sets Mealy
        /// </summary>
        [DataMember(Name = "mealy", EmitDefaultValue = true)]
        public bool Mealy
        {
            get{ return _Mealy;}
            set
            {
                _Mealy = value;
                _flagMealy = true;
            }
        }
        private bool _Mealy;
        private bool _flagMealy;

        /// <summary>
        /// Returns false as Mealy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMealy()
        {
            return _flagMealy;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppleReq {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Mealy: ").Append(Mealy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as AppleReq).AreEqual;
        }

        /// <summary>
        /// Returns true if AppleReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleReq input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (this.Cultivar != null)
                {
                    hashCode = (hashCode * 59) + this.Cultivar.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mealy.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
