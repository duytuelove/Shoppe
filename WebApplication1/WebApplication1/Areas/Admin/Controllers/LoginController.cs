using Model.Dow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.Admin.Models;
using WebApplication1.Common;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dow = new UserDow();
                var resul = dow.Login(model.UserName, Encryptor.MD5Hash( model.Password));
                if (resul == 1)
                {
                    var user = dow.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstnant.USER_SESSION, userSession);

                    return RedirectToAction("Index", "Home");
                }
                else if(resul == 0)
                {
                    ModelState.AddModelError("", "Tai khoan khong ton tai!!!");
                }
                else if (resul == -1)
                {
                    ModelState.AddModelError("", "Tai khoan dang bi khoa!!!");
                }
                else if (resul == -2)
                {
                    ModelState.AddModelError("", "Mat khau khong dung!!!");
                }
                else
                {
                    ModelState.AddModelError("", "Dang nhap khong dung!!!");
                }
            }
            return View("Index");
        }
    }
}