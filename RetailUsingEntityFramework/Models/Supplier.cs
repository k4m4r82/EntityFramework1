using System;
using System.Collections.Generic;

namespace RetailUsingEntityFramework.Models
{
    public partial class Supplier
    {
        public int SupplierID { get; set; }
        public string NamaSupplier { get; set; }
        public string Jalan { get; set; }
        public string Kota { get; set; }
    }
}
