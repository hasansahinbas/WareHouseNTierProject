using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Entity;

namespace WareHouseNTierProject.Model.Option
{
    public class Product:CoreEntity
    {
        public decimal? Price { get; set; }
        public string ProductName { get; set; }
        public short? UnitInStock { get; set; }
        public string Quantity { get; set; }

        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public Guid SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
