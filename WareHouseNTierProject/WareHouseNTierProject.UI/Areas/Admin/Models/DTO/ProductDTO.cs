using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WareHouseNTierProject.UI.Areas.Admin.Models.DTO
{
    public class ProductDTO : BaseDTO
    {
        public decimal? Price { get; set; }
        public short? UnitInStock { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }

        public Guid CategoryID { get; set; }
        public string Name { get; set; }

        public Guid SupplierID { get; set; }
        public string CompanyName { get; set; }
    }
}