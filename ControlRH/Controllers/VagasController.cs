using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class VagasController : Controller
    {
        VagasRepository _vagasRepository = new VagasRepository();

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new VagasViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _vagasRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetVagas(VagasViewModel usuario)
        {
            try
            {
                var model = new VagasViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _vagasRepository.GetVagasByParam(HttpContext.Session.GetString("SessionToken"), usuario.NomeVaga);

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateVagas(Vagas model)
        {
            try
            {
                var response = _vagasRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetVagasQuantidade()
        {
            try
            {
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                var value = await _vagasRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return Ok(value.Count());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdateVagas(Vagas model)
        {
            try
            {
                var response = _vagasRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
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
        public async Task<IActionResult> DeleteVagas(int Id)
        {
            try
            {
                var token = HttpContext.Session.GetString("SessionToken");
                var response = await _vagasRepository.Delete(Id, token);
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
