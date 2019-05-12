using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WareHouseNTierProject.Model.Option;
using WareHouseNTierProject.Service.Option;
using WareHouseNTierProject.UI.Areas.Admin.Models.DTO;

namespace WareHouseNTierProject.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        // GET: Admin/Category
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category data)
        {
            _categoryService.Add(data);
            return Redirect("/Admin/Category/CategoryList");
        }

        public ActionResult CategoryList()
        {
            List<Category> model = _categoryService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Category cat = _categoryService.GetByID(id);
            CategoryDTO model = new CategoryDTO();
            model.ID = cat.ID;
            model.Name = cat.Name;
            model.Description = cat.Description;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(CategoryDTO data)
        {
            Category cat = _categoryService.GetByID(data.ID);

            cat.Name = data.Name;
            cat.Description = data.Description;
            _categoryService.Update(cat);
            return Redirect("/Admin/Category/CategoryList");
        }

        public ActionResult Delete(Guid id)
        {
            _categoryService.Remove(id);
            return Redirect("/Admin/Category/CategoryList");

        }

    }
}