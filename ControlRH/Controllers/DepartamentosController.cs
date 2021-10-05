using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class DepartamentosController : Controller
    {
        DepartamentoRepository _depart = new DepartamentoRepository();
        FuncionarioRepository _funcionarioRepository = new FuncionarioRepository();
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new DepartamentoViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.itensReturnToTable = await _depart.Get(HttpContext.Session.GetString("SessionToken"));
                model.itensReturnToSelect = await _depart.Get(HttpContext.Session.GetString("SessionToken"));
                model.GestorReturnSelect = await _funcionarioRepository.Get(HttpContext.Session.GetString("SessionToken"));


                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> FiltroDepartamento(Departamento departamento)
        {
            try
            {
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");
                var model = new DepartamentoViewModel();

                model.itensReturnToSelect = await _depart.Get(HttpContext.Session.GetString("SessionToken"));
                model.itensReturnToTable = await _depart.GetDerpWithName(HttpContext.Session.GetString("SessionToken"), departamento.NomeDepartamento); ;
                model.GestorReturnSelect = await _funcionarioRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View("Index", model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IActionResult InsertDepartamento(Departamento departamento)
        {
            try
            { 
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                var response = _depart.Create(departamento, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public IActionResult EditDepartamento(Departamento departamento)
        {
            try
            {
                //Validar sessão
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                var response = _depart.Update(departamento, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            try
            {
                //Validar sessão
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                var response = await _depart.Delete(id, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public async Task<IActionResult> ReturnDadosDepartamentoEdit(int id)
        {
            try
            {
                //Validar sessão
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                var model = await _depart.Details(id, HttpContext.Session.GetString("SessionToken"));

                return Ok(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
