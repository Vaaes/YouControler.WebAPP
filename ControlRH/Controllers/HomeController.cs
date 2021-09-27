using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class HomeController : Controller
    {
        BaseController _base = new BaseController();
        LogInRepository _login = new LogInRepository();
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            try
            {
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> ReturnAllMenusOnPartialView()
        {
            var model = new ControleAcessoViewModel();
            if (HttpContext.Session.GetString("SessionName") == null)
                return RedirectToAction("LogOut");

            model.Itens = await _login.Get(HttpContext.Session.GetString("SessionToken"), HttpContext.Session.GetInt32("SessionIdNivelAcesso"));

            return PartialView("_Menus", model);
        }

        public async Task<IActionResult> HasPermissionAllowed(int IdMenu)
        {
            var access = await _login.HasPermission(HttpContext.Session.GetString("SessionToken"), HttpContext.Session.GetInt32("SessionIdNivelAcesso"), IdMenu);    
            return Ok(access);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                if (cookie == ".AspNetCore.Session")
                    Response.Cookies.Delete(cookie);
            }
            return RedirectToAction("Index", "LogIn");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
