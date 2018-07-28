﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace Financas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(string login, string senha)
        {
            if(WebSecurity.Login(login, senha)){
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("login.Invalido", "Login ou senha incorretos");
                return View("Index", "Movimentacao");
            }
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index");
        }
    }
}