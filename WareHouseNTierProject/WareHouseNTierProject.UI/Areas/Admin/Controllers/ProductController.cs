using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WareHouseNTierProject.Model.Option;
using WareHouseNTierProject.Service.Option;
using WareHouseNTierProject.UI.Areas.Admin.Models.DTO;
using WareHouseNTierProject.UI.Areas.Admin.Models.VM;

namespace WareHouseNTierProject.UI.Areas.Admin.Controllers
{

    public class ProductController : Controller
    {
        CategoryService _categoryService;
        ProductService _productService;
        SupplierService _supplierService;
        public ProductController()
        {
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _supplierService = new SupplierService();
        }
        public ActionResult Add()
        {
            AddProductVM model = new AddProductVM();

            model.Categories = _categoryService.GetActive();
            model.Suppliers = _supplierService.GetActive();
            return View(model);
            
        }

        [HttpPost]
        public ActionResult Add(Product data)
        {
            
            _productService.Add(data);
            return Redirect("/Admin/Product/ProductList");
        }

        public ActionResult ProductList()
        {
            List<Product> model = _productService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Product product = _productService.GetByID(id);
            AddProductVM model = new AddProductVM();
            model.Products.ID = product.ID;
            model.Products.Price = product.Price;
            model.Products.ProductName = product.ProductName;
            model.Products.Quantity = product.Quantity;
            model.Products.UnitInStock = product.UnitInStock;
            model.Products.CategoryID = product.CategoryID;
            model.Products.SupplierID = product.SupplierID;
            model.Categories = _categoryService.GetActive();
            model.Suppliers = _supplierService.GetActive();

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ProductDTO data)
        {
            Product product = _productService.GetByID(data.ID);
            product.ProductName = data.ProductName;
            product.Price = data.Price;
            product.Quantity = data.Quantity;
            product.UnitInStock = data.UnitInStock;
            product.SupplierID = data.SupplierID;
            product.CategoryID = data.CategoryID;
           
            
            
            _productService.Update(product);
            return Redirect("/Admin/Product/ProductList");
        }

        public ActionResult Delete(Guid id)
        {
            _productService.Remove(id);
            return Redirect("/Admin/Product/ProductList");
        }
    }
}
