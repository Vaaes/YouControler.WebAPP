using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class CargoController : Controller
    {
        CargoRepository _cargoRepository = new CargoRepository();
        FuncionarioRepository _funcionarioRepository = new FuncionarioRepository();
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new CargoViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _cargoRepository.Get(HttpContext.Session.GetString("SessionToken"));
                model.ItensToSelect = await _cargoRepository.Get(HttpContext.Session.GetString("SessionToken"));
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetCargo(CargoViewModel cargo)
        {
            try
            {
                var model = new CargoViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _cargoRepository.GetCargoByParam(HttpContext.Session.GetString("SessionToken"), cargo.Nome_Cargo);
                model.ItensToSelect = await _cargoRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> VerificaFuncionarioByIdCargo(int IdCargo)
        {
            try
            {
                var model = new FuncionarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _funcionarioRepository.VerificaFuncionarioByIdCargo(HttpContext.Session.GetString("SessionToken"), IdCargo);
                if (model.Itens.Count() > 0)
                    return Ok(false);
                return Ok(true); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateCargo(Cargo model)
        {
            try
            {
                var response = _cargoRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdateCargo(Cargo model)
        {
            try
            {
                var response = _cargoRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
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
        public async Task<IActionResult> DeleteCargo(int Id)
        {
            try
            {
                var token = HttpContext.Session.GetString("SessionToken");
                var response = await _cargoRepository.Delete(Id, token);
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

