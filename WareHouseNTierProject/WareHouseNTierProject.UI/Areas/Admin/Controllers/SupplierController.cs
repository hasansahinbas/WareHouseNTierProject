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
            model.ID = supplier.ID;
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
        public ActionResult Update(SupplierDTO data)
        {
            Supplier supplier = _supplierService.GetByID(data.ID);

            supplier.CompanyName=data.CompanyName;
            supplier.ContactName = data.ContactName;
            supplier.Address = data.Address;
            supplier.City =data.City;
            supplier.Country = data.Country;
            supplier.FaxNumber = data.FaxNumber;
            supplier.PhoneNumber = data.PhoneNumber;
            supplier.PostalCode = data.PostalCode;
            
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