using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Map;
using WareHouseNTierProject.Model.Option;

namespace WareHouseNTierProject.Map.Option
{
    public class ProductMap:CoreMap<Product>
    {

        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(x => x.ProductName).HasMaxLength(50).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.UnitInStock).IsRequired();
            Property(x => x.Quantity).IsRequired();

            HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(true);

            HasRequired(x => x.Supplier)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.SupplierID)
                .WillCascadeOnDelete(true);
        }
    }
}
