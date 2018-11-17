﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NetCoreTestApp.DataAccess.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
