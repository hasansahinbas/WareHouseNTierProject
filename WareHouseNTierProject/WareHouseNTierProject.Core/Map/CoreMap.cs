using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Entity;

namespace WareHouseNTierProject.Core.Map
{
    public class CoreMap<T>:EntityTypeConfiguration<T>  where T:CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasColumnName("ID").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CreatedUserName).HasColumnName("CreatedUserName").HasMaxLength(50).IsRequired();
            Property(x => x.CreatedComputerName).HasColumnName("CreatedComputerName").HasMaxLength(50).IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreatedDate").IsRequired();
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired();
            Property(x => x.CreatedIP).HasColumnName("CreatedIP").IsRequired();

            Property(x => x.ModifiedUserName).HasColumnName("ModifiedUserName").HasMaxLength(50).IsRequired();
            Property(x => x.ModifiedComputerName).HasColumnName("ModifiedComputerName").HasMaxLength(50).IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsRequired();
            Property(x => x.ModifiedIP).HasColumnName("ModifiedIP").IsRequired();
                

        }
    }
}
