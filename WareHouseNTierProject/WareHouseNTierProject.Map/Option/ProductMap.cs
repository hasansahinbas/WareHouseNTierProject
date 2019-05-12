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
            Property(x => x.ProductName).HasMaxLength(50).IsOptional();
            Property(x => x.Price).IsOptional();
            Property(x => x.UnitInStock).IsOptional();
            Property(x => x.Quantity).IsOptional();

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
