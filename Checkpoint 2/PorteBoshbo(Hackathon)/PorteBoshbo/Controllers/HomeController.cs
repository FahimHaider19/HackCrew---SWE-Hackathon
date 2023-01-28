using BLL.DTOs;
using BLL.Services;
using PorteBoshbo.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PorteBoshbo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDTO user)
        {
            var users = UserService.Get();
            bool flag = false;
            foreach(var u in users)
            {
                if(u.Email==user.Email && u.Password==user.Password) 
                {
                    flag= true;
                    break;
                }
            }
            if(!flag)
                return RedirectToAction("About");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}