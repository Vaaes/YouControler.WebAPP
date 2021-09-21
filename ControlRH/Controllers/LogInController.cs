using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class LogInController : Controller
    {
        private readonly ILogger<LogInController> _logger;
        LogInRepository _login = new LogInRepository();
        public LogInController(ILogger<LogInController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ValidaAcessoUsuario(Usuario model)
        {
            var SessionValue = await _login.Details(model);

            HttpContext.Session.SetString("SessionName", SessionValue.Nome);
            HttpContext.Session.SetString("SessionToken", SessionValue.token);
            HttpContext.Session.SetInt32("SessionId", SessionValue.Id);

            return RedirectToAction("Index", "Home");
        }
    }
}
