using Model.Dow;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Common;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var dow = new UserDow();
            var model = dow.ListAllPaging(page, pageSize);

            return View(model);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Edit(int id)
        {
            var user = new UserDow().ViewDetail(id);
            return View(user);
        }
        // GET: Admin/User/Create
        [HttpPost]
        public ActionResult Create(tblUser user)
        {
            if (ModelState.IsValid)
            {
                var dow = new UserDow();

                var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
                user.Password = encryptedMd5Pas;
                long id = dow.Insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm thành công");
                }
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult Edit(tblUser user)
        {
            if (ModelState.IsValid)
            {
                var dow = new UserDow();
                if (!string.IsNullOrEmpty(user.Password))
                {
                    var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
                    user.Password = encryptedMd5Pas;
                }
               
                var resul = dow.Update(user);
                if (resul)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thành công");
                }
            }
            return View("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDow().Delete(id);
            return RedirectToAction("Index");
        }
    }
}
