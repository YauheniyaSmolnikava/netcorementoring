using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTestApp.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("ProductName")]
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        [DisplayName("Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }

        [DisplayName("Unit Price")]
        public decimal? UnitPrice { get; set; }

        [DisplayName("Units in Stock")]
        public short? UnitsInStock { get; set; }

        [DisplayName("Units on Order")]
        public short? UnitsOnOrder { get; set; }

        [Range(0, 35)]
        [DisplayName("Reorder Level")]
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
