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
    /// Employees
    /// </summary>
    [DataContract]
    public partial class Employees :  IEquatable<Employees>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employees" /> class.
        /// </summary>
        /// <param name="EmployeeId">EmployeeId.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="Title">Title.</param>
        /// <param name="TitleOfCourtesy">TitleOfCourtesy.</param>
        /// <param name="BirthDate">BirthDate.</param>
        /// <param name="HireDate">HireDate.</param>
        /// <param name="Address">Address.</param>
        /// <param name="City">City.</param>
        /// <param name="Region">Region.</param>
        /// <param name="PostalCode">PostalCode.</param>
        /// <param name="Country">Country.</param>
        /// <param name="HomePhone">HomePhone.</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="Photo">Photo.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="ReportsTo">ReportsTo.</param>
        /// <param name="PhotoPath">PhotoPath.</param>
        /// <param name="ReportsToNavigation">ReportsToNavigation.</param>
        /// <param name="EmployeeTerritories">EmployeeTerritories.</param>
        /// <param name="InverseReportsToNavigation">InverseReportsToNavigation.</param>
        /// <param name="Orders">Orders.</param>
        public Employees(int? EmployeeId = default(int?), string LastName = default(string), string FirstName = default(string), string Title = default(string), string TitleOfCourtesy = default(string), DateTime? BirthDate = default(DateTime?), DateTime? HireDate = default(DateTime?), string Address = default(string), string City = default(string), string Region = default(string), string PostalCode = default(string), string Country = default(string), string HomePhone = default(string), string Extension = default(string), byte[] Photo = default(byte[]), string Notes = default(string), int? ReportsTo = default(int?), string PhotoPath = default(string), Employees ReportsToNavigation = default(Employees), List<EmployeeTerritories> EmployeeTerritories = default(List<EmployeeTerritories>), List<Employees> InverseReportsToNavigation = default(List<Employees>), List<Orders> Orders = default(List<Orders>))
        {
            this.EmployeeId = EmployeeId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Title = Title;
            this.TitleOfCourtesy = TitleOfCourtesy;
            this.BirthDate = BirthDate;
            this.HireDate = HireDate;
            this.Address = Address;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.HomePhone = HomePhone;
            this.Extension = Extension;
            this.Photo = Photo;
            this.Notes = Notes;
            this.ReportsTo = ReportsTo;
            this.PhotoPath = PhotoPath;
            this.ReportsToNavigation = ReportsToNavigation;
            this.EmployeeTerritories = EmployeeTerritories;
            this.InverseReportsToNavigation = InverseReportsToNavigation;
            this.Orders = Orders;
        }
        
        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleOfCourtesy
        /// </summary>
        [DataMember(Name="titleOfCourtesy", EmitDefaultValue=false)]
        public string TitleOfCourtesy { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name="birthDate", EmitDefaultValue=false)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets HireDate
        /// </summary>
        [DataMember(Name="hireDate", EmitDefaultValue=false)]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets HomePhone
        /// </summary>
        [DataMember(Name="homePhone", EmitDefaultValue=false)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name="photo", EmitDefaultValue=false)]
        public byte[] Photo { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets ReportsTo
        /// </summary>
        [DataMember(Name="reportsTo", EmitDefaultValue=false)]
        public int? ReportsTo { get; set; }

        /// <summary>
        /// Gets or Sets PhotoPath
        /// </summary>
        [DataMember(Name="photoPath", EmitDefaultValue=false)]
        public string PhotoPath { get; set; }

        /// <summary>
        /// Gets or Sets ReportsToNavigation
        /// </summary>
        [DataMember(Name="reportsToNavigation", EmitDefaultValue=false)]
        public Employees ReportsToNavigation { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeTerritories
        /// </summary>
        [DataMember(Name="employeeTerritories", EmitDefaultValue=false)]
        public List<EmployeeTerritories> EmployeeTerritories { get; set; }

        /// <summary>
        /// Gets or Sets InverseReportsToNavigation
        /// </summary>
        [DataMember(Name="inverseReportsToNavigation", EmitDefaultValue=false)]
        public List<Employees> InverseReportsToNavigation { get; set; }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<Orders> Orders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Employees {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleOfCourtesy: ").Append(TitleOfCourtesy).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  HireDate: ").Append(HireDate).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ReportsTo: ").Append(ReportsTo).Append("\n");
            sb.Append("  PhotoPath: ").Append(PhotoPath).Append("\n");
            sb.Append("  ReportsToNavigation: ").Append(ReportsToNavigation).Append("\n");
            sb.Append("  EmployeeTerritories: ").Append(EmployeeTerritories).Append("\n");
            sb.Append("  InverseReportsToNavigation: ").Append(InverseReportsToNavigation).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
            return this.Equals(input as Employees);
        }

        /// <summary>
        /// Returns true if Employees instances are equal
        /// </summary>
        /// <param name="input">Instance of Employees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employees input)
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
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleOfCourtesy == input.TitleOfCourtesy ||
                    (this.TitleOfCourtesy != null &&
                    this.TitleOfCourtesy.Equals(input.TitleOfCourtesy))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.HireDate == input.HireDate ||
                    (this.HireDate != null &&
                    this.HireDate.Equals(input.HireDate))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.HomePhone == input.HomePhone ||
                    (this.HomePhone != null &&
                    this.HomePhone.Equals(input.HomePhone))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Photo == input.Photo ||
                    (this.Photo != null &&
                    this.Photo.Equals(input.Photo))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ReportsTo == input.ReportsTo ||
                    (this.ReportsTo != null &&
                    this.ReportsTo.Equals(input.ReportsTo))
                ) && 
                (
                    this.PhotoPath == input.PhotoPath ||
                    (this.PhotoPath != null &&
                    this.PhotoPath.Equals(input.PhotoPath))
                ) && 
                (
                    this.ReportsToNavigation == input.ReportsToNavigation ||
                    (this.ReportsToNavigation != null &&
                    this.ReportsToNavigation.Equals(input.ReportsToNavigation))
                ) && 
                (
                    this.EmployeeTerritories == input.EmployeeTerritories ||
                    this.EmployeeTerritories != null &&
                    this.EmployeeTerritories.SequenceEqual(input.EmployeeTerritories)
                ) && 
                (
                    this.InverseReportsToNavigation == input.InverseReportsToNavigation ||
                    this.InverseReportsToNavigation != null &&
                    this.InverseReportsToNavigation.SequenceEqual(input.InverseReportsToNavigation)
                ) && 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
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
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleOfCourtesy != null)
                    hashCode = hashCode * 59 + this.TitleOfCourtesy.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.HireDate != null)
                    hashCode = hashCode * 59 + this.HireDate.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.HomePhone != null)
                    hashCode = hashCode * 59 + this.HomePhone.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Photo != null)
                    hashCode = hashCode * 59 + this.Photo.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ReportsTo != null)
                    hashCode = hashCode * 59 + this.ReportsTo.GetHashCode();
                if (this.PhotoPath != null)
                    hashCode = hashCode * 59 + this.PhotoPath.GetHashCode();
                if (this.ReportsToNavigation != null)
                    hashCode = hashCode * 59 + this.ReportsToNavigation.GetHashCode();
                if (this.EmployeeTerritories != null)
                    hashCode = hashCode * 59 + this.EmployeeTerritories.GetHashCode();
                if (this.InverseReportsToNavigation != null)
                    hashCode = hashCode * 59 + this.InverseReportsToNavigation.GetHashCode();
                if (this.Orders != null)
                    hashCode = hashCode * 59 + this.Orders.GetHashCode();
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
