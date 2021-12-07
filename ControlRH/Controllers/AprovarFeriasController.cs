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
    public class AprovarFeriasController : Controller
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

                model.Itens = await _feriasRepository.GetFeriasByParam(HttpContext.Session.GetString("SessionToken"), ferias.Data_Inicio, ferias.Data_Final, ferias.Id, ferias.IdUsuario, ferias.Aprovado);

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult AprovacaoFerias(int Id, int approved)
        {
            try
            {
                var model = new Ferias();
                model.IdUsuario = Id;
                model.Aprovacao = approved;


                var response = _feriasRepository.AprovarFerias(HttpContext.Session.GetString("SessionToken"), Id, approved);
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
