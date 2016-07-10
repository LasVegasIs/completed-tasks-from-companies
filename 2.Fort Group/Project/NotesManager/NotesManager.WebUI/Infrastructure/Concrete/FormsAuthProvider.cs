using System;
using System.Web.Security;
using NotesManager.WebUI.Infrastructure.Abstract;
using System.Web;
using NotesManager.Domain.Abstract;
using NotesManager.Domain.Concrete;
using NotesManager.Domain.Entities;

namespace NotesManager.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        private IUserRepository repository;
        public FormsAuthProvider(IUserRepository UserRepository)
        {
            this.repository = UserRepository;
        }
        public bool Authenticate(string username, string password)
        {
            tbUser tbu = repository.GetUser(username, password);
            bool result = tbu != null; //FormsAuthentication.Authenticate(username, password);
            if (result) //if exists this user 
            {
                HttpContext.Current.Response.Cookies["userID"].Value = tbu.ID.ToString();
                HttpContext.Current.Response.Cookies["userID"].Expires = DateTime.Now.AddDays(1);
                HttpContext.Current.Session["UserName"] = username;
                FormsAuthentication.SetAuthCookie(username, false);               
            }
            return result;
        }       
    }
}