using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Map;
using WareHouseNTierProject.Model.Option;

namespace WareHouseNTierProject.Map.Option
{
    public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.Address).HasMaxLength(150).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            Property(x => x.LastName).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired();
            Property(x => x.Role).IsRequired();
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.Birthdate).HasColumnType("datetime2").IsRequired();
        }
    }
}
