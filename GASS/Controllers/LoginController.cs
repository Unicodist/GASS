using System.Linq;
using dbpro1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dbpro.Controllers
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
            DataContext dal = new DataContext();
            dal.users.Add(new UserModel(userRegister.regFName, userRegister.regLName, userRegister.regUserName, userRegister.regEmail, userRegister.regPW,"user"));
            dal.SaveChanges();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult LogAction(LoginModel login)
        {
            DataContext dal = new DataContext();
            var stupid = dal.users.Where(x=>x.username.Equals(login.username)).ToList();
            UserModel user = stupid[0];
            HttpContext.Session.SetString("User",JsonConvert.SerializeObject(user));
            ViewBag.user = JsonConvert.DeserializeObject<UserModel>(HttpContext.Session.GetString("User"));
            return RedirectToAction("Index","Home");
        }

    }
}
