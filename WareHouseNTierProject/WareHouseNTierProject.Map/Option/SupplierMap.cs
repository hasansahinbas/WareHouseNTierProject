using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Map;
using WareHouseNTierProject.Model.Option;

namespace WareHouseNTierProject.Map.Option
{
    public class SupplierMap:CoreMap<Supplier>
    {
        public SupplierMap()
        {
            ToTable("dbo.Suppliers");
            Property(x => x.CompanyName).HasMaxLength(100).IsRequired();
            Property(x => x.ContactName).HasMaxLength(50).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired();
            Property(x => x.FaxNumber).HasMaxLength(50).IsOptional();
            Property(x => x.PostalCode).IsRequired();
            Property(x => x.Country).HasMaxLength(50).IsRequired();
            Property(x => x.City).HasMaxLength(50).IsRequired();
            Property(x => x.Address).HasMaxLength(150).IsRequired();

            HasMany(x => x.Products)
                .WithRequired(x => x.Supplier)
                .HasForeignKey(x => x.SupplierID);

        }
    }
}
