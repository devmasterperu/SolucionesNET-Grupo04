using BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginBEAN login)
        {
            try
            {
                //obtener los valores de la BD
                if (login.User == "admin" && login.Pass == "12345")
                {
                    Session["usuario"] = "ADMIN";
                    //Redireccionar a otra página
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ActionResult CerrarSesion()
        {
            Session.Contents.RemoveAll();
            return RedirectToAction("Login", "Login");
        }
    }
}