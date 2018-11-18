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
    /// Products
    /// </summary>
    [DataContract]
    public partial class Products :  IEquatable<Products>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Products" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Products() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Products" /> class.
        /// </summary>
        /// <param name="ProductId">ProductId.</param>
        /// <param name="ProductName">ProductName (required).</param>
        /// <param name="SupplierId">SupplierId.</param>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="QuantityPerUnit">QuantityPerUnit.</param>
        /// <param name="UnitPrice">UnitPrice.</param>
        /// <param name="UnitsInStock">UnitsInStock.</param>
        /// <param name="UnitsOnOrder">UnitsOnOrder.</param>
        /// <param name="ReorderLevel">ReorderLevel.</param>
        /// <param name="Discontinued">Discontinued.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Supplier">Supplier.</param>
        /// <param name="OrderDetails">OrderDetails.</param>
        public Products(int? ProductId = default(int?), string ProductName = default(string), int? SupplierId = default(int?), int? CategoryId = default(int?), string QuantityPerUnit = default(string), double? UnitPrice = default(double?), int? UnitsInStock = default(int?), int? UnitsOnOrder = default(int?), int? ReorderLevel = default(int?), bool? Discontinued = default(bool?), Categories Category = default(Categories), Suppliers Supplier = default(Suppliers), List<OrderDetails> OrderDetails = default(List<OrderDetails>))
        {
            // to ensure "ProductName" is required (not null)
            if (ProductName == null)
            {
                throw new InvalidDataException("ProductName is a required property for Products and cannot be null");
            }
            else
            {
                this.ProductName = ProductName;
            }
            this.ProductId = ProductId;
            this.SupplierId = SupplierId;
            this.CategoryId = CategoryId;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;
            this.Discontinued = Discontinued;
            this.Category = Category;
            this.Supplier = Supplier;
            this.OrderDetails = OrderDetails;
        }
        
        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets SupplierId
        /// </summary>
        [DataMember(Name="supplierId", EmitDefaultValue=false)]
        public int? SupplierId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets QuantityPerUnit
        /// </summary>
        [DataMember(Name="quantityPerUnit", EmitDefaultValue=false)]
        public string QuantityPerUnit { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitsInStock
        /// </summary>
        [DataMember(Name="unitsInStock", EmitDefaultValue=false)]
        public int? UnitsInStock { get; set; }

        /// <summary>
        /// Gets or Sets UnitsOnOrder
        /// </summary>
        [DataMember(Name="unitsOnOrder", EmitDefaultValue=false)]
        public int? UnitsOnOrder { get; set; }

        /// <summary>
        /// Gets or Sets ReorderLevel
        /// </summary>
        [DataMember(Name="reorderLevel", EmitDefaultValue=false)]
        public int? ReorderLevel { get; set; }

        /// <summary>
        /// Gets or Sets Discontinued
        /// </summary>
        [DataMember(Name="discontinued", EmitDefaultValue=false)]
        public bool? Discontinued { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public Categories Category { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name="supplier", EmitDefaultValue=false)]
        public Suppliers Supplier { get; set; }

        /// <summary>
        /// Gets or Sets OrderDetails
        /// </summary>
        [DataMember(Name="orderDetails", EmitDefaultValue=false)]
        public List<OrderDetails> OrderDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Products {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  QuantityPerUnit: ").Append(QuantityPerUnit).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UnitsInStock: ").Append(UnitsInStock).Append("\n");
            sb.Append("  UnitsOnOrder: ").Append(UnitsOnOrder).Append("\n");
            sb.Append("  ReorderLevel: ").Append(ReorderLevel).Append("\n");
            sb.Append("  Discontinued: ").Append(Discontinued).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  OrderDetails: ").Append(OrderDetails).Append("\n");
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
            return this.Equals(input as Products);
        }

        /// <summary>
        /// Returns true if Products instances are equal
        /// </summary>
        /// <param name="input">Instance of Products to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Products input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.SupplierId == input.SupplierId ||
                    (this.SupplierId != null &&
                    this.SupplierId.Equals(input.SupplierId))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.QuantityPerUnit == input.QuantityPerUnit ||
                    (this.QuantityPerUnit != null &&
                    this.QuantityPerUnit.Equals(input.QuantityPerUnit))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.UnitsInStock == input.UnitsInStock ||
                    (this.UnitsInStock != null &&
                    this.UnitsInStock.Equals(input.UnitsInStock))
                ) && 
                (
                    this.UnitsOnOrder == input.UnitsOnOrder ||
                    (this.UnitsOnOrder != null &&
                    this.UnitsOnOrder.Equals(input.UnitsOnOrder))
                ) && 
                (
                    this.ReorderLevel == input.ReorderLevel ||
                    (this.ReorderLevel != null &&
                    this.ReorderLevel.Equals(input.ReorderLevel))
                ) && 
                (
                    this.Discontinued == input.Discontinued ||
                    (this.Discontinued != null &&
                    this.Discontinued.Equals(input.Discontinued))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
                ) && 
                (
                    this.OrderDetails == input.OrderDetails ||
                    this.OrderDetails != null &&
                    this.OrderDetails.SequenceEqual(input.OrderDetails)
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.SupplierId != null)
                    hashCode = hashCode * 59 + this.SupplierId.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.QuantityPerUnit != null)
                    hashCode = hashCode * 59 + this.QuantityPerUnit.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UnitsInStock != null)
                    hashCode = hashCode * 59 + this.UnitsInStock.GetHashCode();
                if (this.UnitsOnOrder != null)
                    hashCode = hashCode * 59 + this.UnitsOnOrder.GetHashCode();
                if (this.ReorderLevel != null)
                    hashCode = hashCode * 59 + this.ReorderLevel.GetHashCode();
                if (this.Discontinued != null)
                    hashCode = hashCode * 59 + this.Discontinued.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Supplier != null)
                    hashCode = hashCode * 59 + this.Supplier.GetHashCode();
                if (this.OrderDetails != null)
                    hashCode = hashCode * 59 + this.OrderDetails.GetHashCode();
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
            // ProductName (string) maxLength
            if(this.ProductName != null && this.ProductName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductName, length must be less than 100.", new [] { "ProductName" });
            }

            // ProductName (string) minLength
            if(this.ProductName != null && this.ProductName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductName, length must be greater than 0.", new [] { "ProductName" });
            }

            // ReorderLevel (int?) maximum
            if(this.ReorderLevel > (int?)35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReorderLevel, must be a value less than or equal to 35.", new [] { "ReorderLevel" });
            }

            // ReorderLevel (int?) minimum
            if(this.ReorderLevel < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReorderLevel, must be a value greater than or equal to 0.", new [] { "ReorderLevel" });
            }

            yield break;
        }
    }

}
