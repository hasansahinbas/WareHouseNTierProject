using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WareHouseNTierProject.Model.Option;
using WareHouseNTierProject.UI.Areas.Admin.Models.DTO;

namespace WareHouseNTierProject.UI.Areas.Admin.Models.VM
{
    public class AddProductVM
    {
        public AddProductVM()
        {
            Categories = new List<Category>();
            Products = new ProductDTO();
            Suppliers = new List<Supplier>();
        }
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }
        public ProductDTO Products { get; set; }
    }
}