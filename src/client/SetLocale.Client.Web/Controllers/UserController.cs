﻿using System.Web.Mvc;
using SetLocale.Client.Web.Models;

namespace SetLocale.Client.Web.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Reset()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            var model = new LoginModel()
            {
                Email = "dev@test.com",
                Password = "password"
            };

            return View(model);
        }
    }
}