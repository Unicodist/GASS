using System.Collections.Generic;
using System.Linq;
using GASS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GASS.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Active = "nav_login";
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.Active = "nav_signup";
            return View();
        } 

        public IActionResult RegAction(UserRegisterModel userRegister)
        {
            GASSDBContext dal = new GASSDBContext();
            dal.users.Add(new UserModel(userRegister.regFName, userRegister.regLName, userRegister.regUserName, userRegister.regEmail, Tools.GetMD5(userRegister.regPW),"user"));
            dal.SaveChanges();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult LogAction(LoginModel formInput)
        {
            List<string> error_list = new List<string>();
            GASSDBContext dal = new GASSDBContext();
            var users = dal.users.Where(x => x.username.ToLower().Equals(formInput.username.ToLower())).ToList();
            if (users.Count() == 1 && users[0].password.Equals(Tools.GetMD5(formInput.password))) {
                HttpContext.Session.SetString("User", JsonConvert.SerializeObject(users[0]));
                HttpContext.Session.SetString("logged", "true");
                return RedirectToAction("Index", "Panel");
            }
            if (users.Count() == 0) error_list.Add("no_user");
            else error_list.Add("wrong_pw");
            return RedirectToAction("Index","Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Logged", "null");
            HttpContext.Session.SetString("User", "null");
            return RedirectToAction("Index", "Login");
        }

    }
}
