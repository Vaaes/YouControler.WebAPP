using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class HomeController : Controller
    {
        BaseController _base = new BaseController();
        LogInRepository _login = new LogInRepository();
        UsuarioRepository _usuarioRepository = new UsuarioRepository();
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
            try
            {
                var access = await _login.HasPermission(HttpContext.Session.GetString("SessionToken"), HttpContext.Session.GetInt32("SessionIdNivelAcesso"), IdMenu);
                return Ok(access);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> VerifyIfItsDefaultPassword()
        {
            try
            {
                var model = new UsuarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _usuarioRepository.GetVerificaSenha(HttpContext.Session.GetString("SessionToken"), HttpContext.Session.GetInt32("SessionId"));

                if (model.Itens.Count() >= 1)
                    return Ok(true);
                return Ok(false);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult ChangePassword(string password)
        {
            try
            {
                var model = new Usuario();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Senha = password;
                model.Id = (int)HttpContext.Session.GetInt32("SessionId");
                var response = _usuarioRepository.UpdatePassword(model, HttpContext.Session.GetString("SessionToken"));

                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
