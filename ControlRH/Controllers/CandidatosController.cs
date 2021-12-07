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
    public class CandidatosController : Controller
    {
        CandidatosRepository _candidatosRepository = new CandidatosRepository();

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new CandidatosViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _candidatosRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuario(CandidatosViewModel usuario)
        {
            try
            {
                var model = new CandidatosViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _candidatosRepository.GetCandidatosByParam(HttpContext.Session.GetString("SessionToken"), usuario.Id, usuario.NomeCandidato, usuario.IdadeCandidato, usuario.EmailCandidato, usuario.TelefoneCandidato, usuario.IdVaga);

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateUsuario(Candidatos model)
        {
            try
            {
                var response = _candidatosRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdateUsuario(Candidatos model)
        {
            try
            {
                var response = _candidatosRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
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
        public async Task<IActionResult> DeleteUsuario(int Id)
        {
            try
            {
                var token = HttpContext.Session.GetString("SessionToken");
                var response = await _candidatosRepository.Delete(Id, token);
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
