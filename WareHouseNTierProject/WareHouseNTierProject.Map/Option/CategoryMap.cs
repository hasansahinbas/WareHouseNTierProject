using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Map;
using WareHouseNTierProject.Model.Option;

namespace WareHouseNTierProject.Map.Option
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.Description).HasMaxLength(150).IsRequired();

            HasMany(x => x.Products)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryID);
        }
    }
}
