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
    public class SupplierController : Controller
    {
        SupplierService _supplierService;

        public SupplierController()
        {
            _supplierService = new SupplierService();
        }
        // GET: Admin/Supplier
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Supplier data)
        {
            _supplierService.Add(data);
            return Redirect("/Admin/Supplier/SupplierList");
        }

        public ActionResult SupplierList()
        {
            List<Supplier> model = _supplierService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Supplier supplier = _supplierService.GetByID(id);
            SupplierDTO model = new SupplierDTO();
            model.CompanyName = supplier.CompanyName;
            model.ContactName = supplier.ContactName;
            model.Address = supplier.Address;
            model.City = supplier.City;
            model.Country = supplier.Country;
            model.FaxNumber = supplier.FaxNumber;
            model.PhoneNumber = supplier.PhoneNumber;
            model.PostalCode = supplier.PostalCode;
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(SupplierDTO model)
        {
            Supplier supplier = _supplierService.GetByID(model.ID);

            supplier.CompanyName = model.CompanyName;
            supplier.ContactName = model.ContactName;
            supplier.Address = model.Address;
            supplier.City =model.City;
            supplier.Country = model.Country;
            supplier.FaxNumber = model.FaxNumber;
            supplier.PhoneNumber = model.PhoneNumber;
            supplier.PostalCode = model.PostalCode;
            
            _supplierService.Update(supplier);
            return Redirect("/Admin/Supplier/SupplierList");
        }

        public ActionResult Delete(Guid id)
        {
            _supplierService.Remove(id);
            return Redirect("/Admin/Supplier/SupplierList");

        }
    }
}