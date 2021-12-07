using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class FeriasController : Controller
    {
        FeriasRepository _feriasRepository = new FeriasRepository();

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new FeriasViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _feriasRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetFerias(FeriasViewModel ferias)
        {
            try
            {
                var model = new FeriasViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _feriasRepository.GetFeriasByParam(HttpContext.Session.GetString("SessionToken"), ferias.Data_Inicio, ferias.Data_Final, ferias.Id,  ferias.IdUsuario, ferias.Aprovado);

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAprovacao(int aprovacao)
        {
            try
            {
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                var value = await _feriasRepository.GetAprovacao(HttpContext.Session.GetString("SessionToken"), aprovacao);

                var teste = value.Count();

                return Ok(value.Count());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateFerias(Ferias model)
        {
            try
            {
                model.IdUsuario = (int)HttpContext.Session.GetInt32("SessionId");
                var response = _feriasRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdateFerias(Ferias model)
        {
            try
            {
                model.IdUsuario = (int)HttpContext.Session.GetInt32("SessionId");
                var response = _feriasRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFerias(int Id)
        {
            try
            {
                var token = HttpContext.Session.GetString("SessionToken");
                var response = await _feriasRepository.Delete(Id, token);
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
