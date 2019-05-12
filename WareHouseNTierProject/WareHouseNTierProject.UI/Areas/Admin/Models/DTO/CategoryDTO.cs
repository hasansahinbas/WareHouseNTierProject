using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WareHouseNTierProject.UI.Areas.Admin.Models.DTO
{
    public class CategoryDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}