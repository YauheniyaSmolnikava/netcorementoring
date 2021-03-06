/* 
 * ToDo API
 *
 * A simple example ASP.NET Core Web API
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// EmployeeTerritories
    /// </summary>
    [DataContract]
    public partial class EmployeeTerritories :  IEquatable<EmployeeTerritories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeTerritories" /> class.
        /// </summary>
        /// <param name="EmployeeId">EmployeeId.</param>
        /// <param name="TerritoryId">TerritoryId.</param>
        /// <param name="Employee">Employee.</param>
        /// <param name="Territory">Territory.</param>
        public EmployeeTerritories(int? EmployeeId = default(int?), string TerritoryId = default(string), Employees Employee = default(Employees), Territories Territory = default(Territories))
        {
            this.EmployeeId = EmployeeId;
            this.TerritoryId = TerritoryId;
            this.Employee = Employee;
            this.Territory = Territory;
        }
        
        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets TerritoryId
        /// </summary>
        [DataMember(Name="territoryId", EmitDefaultValue=false)]
        public string TerritoryId { get; set; }

        /// <summary>
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name="employee", EmitDefaultValue=false)]
        public Employees Employee { get; set; }

        /// <summary>
        /// Gets or Sets Territory
        /// </summary>
        [DataMember(Name="territory", EmitDefaultValue=false)]
        public Territories Territory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeTerritories {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  TerritoryId: ").Append(TerritoryId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Territory: ").Append(Territory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as EmployeeTerritories);
        }

        /// <summary>
        /// Returns true if EmployeeTerritories instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeTerritories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeTerritories input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.TerritoryId == input.TerritoryId ||
                    (this.TerritoryId != null &&
                    this.TerritoryId.Equals(input.TerritoryId))
                ) && 
                (
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && 
                (
                    this.Territory == input.Territory ||
                    (this.Territory != null &&
                    this.Territory.Equals(input.Territory))
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
                if (this.EmployeeId != null)
                    hashCode = hashCode * 59 + this.EmployeeId.GetHashCode();
                if (this.TerritoryId != null)
                    hashCode = hashCode * 59 + this.TerritoryId.GetHashCode();
                if (this.Employee != null)
                    hashCode = hashCode * 59 + this.Employee.GetHashCode();
                if (this.Territory != null)
                    hashCode = hashCode * 59 + this.Territory.GetHashCode();
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
