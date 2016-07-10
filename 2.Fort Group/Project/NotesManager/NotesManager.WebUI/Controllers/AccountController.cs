using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NotesManager.WebUI.Infrastructure.Abstract;
using NotesManager.WebUI.Models;
using System.Web.Security;

namespace NotesManager.WebUI.Controllers
{
     [AllowAnonymous]
    public class AccountController : Controller
    { 
        private IAuthProvider authProvider;
        public AccountController(IAuthProvider auth)
        {
         authProvider = auth;
        }
        public ViewResult Login()
        {
         return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(model.UserName, model.Password)) 
                {                   
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("List", "Note"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                        }
                    }
                    else
                        {
                         return View();
                        }
          }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }       
    }
 }

