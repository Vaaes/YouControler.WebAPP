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
    public class FuncionarioController : Controller
    {
        FuncionarioRepository _funcionarioRepository = new FuncionarioRepository();
        CargoRepository _cargoRepository = new CargoRepository();
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new FuncionarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _funcionarioRepository.Get(HttpContext.Session.GetString("SessionToken"));
                model.ItensCargoToselect = await _cargoRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetFuncionario(FuncionarioViewModel funcionario)
        {
            try
            {
                var model = new FuncionarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _funcionarioRepository.GetUsuarioByParam(HttpContext.Session.GetString("SessionToken"), funcionario.Id, funcionario.Nome, funcionario.CPF, funcionario.Tipo, funcionario.Email, funcionario.Salario, funcionario.IdCargo);
                model.ItensCargoToselect = await _cargoRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateFuncionario(Funcionario model)
        {
            try
            {
                var response = _funcionarioRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdateFuncionario(Funcionario model)
        {
            try
            {
                var response = _funcionarioRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
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
        public async Task<IActionResult> DeleteFuncionario(int Id)
        {
            try
            {
                var token = HttpContext.Session.GetString("SessionToken");
                var response = await _funcionarioRepository.Delete(Id, token);
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
