using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class UsuariosController : Controller
    {
        LogInRepository _login = new LogInRepository();

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new ControleAcessoViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _login.Get(HttpContext.Session.GetString("SessionToken"), HttpContext.Session.GetInt32("SessionIdNivelAcesso"));

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
