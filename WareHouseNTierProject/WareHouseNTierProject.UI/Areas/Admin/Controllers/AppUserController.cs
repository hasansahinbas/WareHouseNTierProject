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
    public class AppUserController : Controller
    {
        AppUserService _appUserService;

        public AppUserController()
        {
            _appUserService = new AppUserService();
        }
        // GET: Admin/Category
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            _appUserService.Add(data);
            return Redirect("/Admin/AppUser/AppUserList");
        }

        public ActionResult AppUserList()
        {
            List<AppUser> model = _appUserService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            AppUser user = _appUserService.GetByID(id);
            AppUserDTO model = new AppUserDTO();
            model.ID = user.ID;
            model.Address = user.Address;
            model.Birthdate = user.Birthdate;
            model.Email = user.Email;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Password = user.Password;
            model.PhoneNumber = user.PhoneNumber;
            model.Role = user.Role;
            model.UserName = model.UserName;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(AppUserDTO data)
        {
            AppUser user = _appUserService.GetByID(data.ID);

            user.UserName = data.UserName;
            user.Role = data.Role;
            user.PhoneNumber = data.PhoneNumber;
            user.Password = data.Password;
            user.LastName = data.LastName;
            user.FirstName = data.FirstName;
            user.Email = data.Email;
            user.Birthdate = data.Birthdate;
            user.Address = data.Address;
            _appUserService.Update(user);
            return Redirect("/Admin/AppUser/AppUserList");
        }

        public ActionResult Delete(Guid id)
        {
            _appUserService.Remove(id);
            return Redirect("/Admin/AppUser/AppUserList");

        }
    }
}