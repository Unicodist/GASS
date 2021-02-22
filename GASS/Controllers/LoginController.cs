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
        GASSDBContext dal = new GASSDBContext();
        List<string> error_list = new List<string>();
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
            List<UserModel> doUserExist = dal.users.Where(x => x.username.Equals(userRegister.regUserName)).ToList();
            if (Tools.StrEmpty(userRegister.regFName)) error_list.Add("null_fname");
            if (Tools.StrEmpty(userRegister.regLName)) error_list.Add("null_lname");
            if (Tools.StrEmpty(userRegister.regPW)) error_list.Add("null_pw");
            if (Tools.StrEmpty(userRegister.regUserName)) error_list.Add("null_uname");
            if (Tools.StrEmpty(userRegister.regEmail)) error_list.Add("null_email");
            if (Tools.StrEmpty(userRegister.regConfirm)) error_list.Add("null_confirm");
            if (userRegister.regPW.Equals(userRegister.regConfirm)) error_list.Add("pw_mismatch");
            if (doUserExist.Count() > 0) error_list.Add("existing_user");

            if (error_list.Count > 0)
            {
                TempData["error_list"] = error_list;
                return RedirectToAction("Register", "Login");
            }
            dal.users.Add(new UserModel(userRegister.regFName, userRegister.regLName, userRegister.regUserName, userRegister.regEmail, Tools.GetMD5(userRegister.regPW),"user"));
            dal.SaveChanges();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult LogAction(LoginModel formInput)
        {
            var users = dal.users.Where(x => x.username.ToLower().Equals(formInput.username.ToLower())).ToList();
            if (users.Count() == 1 && users[0].password.Equals(Tools.GetMD5(formInput.password))) {
                HttpContext.Session.SetString("User", JsonConvert.SerializeObject(users[0]));
                HttpContext.Session.SetString("logged", "true");
                return RedirectToAction("Index", "Panel");
            }
            if (users.Count() == 0) error_list.Add("no_user");
            else error_list.Add("wrong_pw");
            return RedirectToAction("Index","Home");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Logged", "null");
            HttpContext.Session.SetString("User", "null");
            return RedirectToAction("Index", "Login");
        }

    }
}
