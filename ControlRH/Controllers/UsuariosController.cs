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
        UsuarioRepository _usuarioRepository = new UsuarioRepository();
        PerfilRepository _perfilRepository = new PerfilRepository();

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new UsuarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _usuarioRepository.Get(HttpContext.Session.GetString("SessionToken"));
                model.ItensToPerfilSelect = await _perfilRepository.Get(HttpContext.Session.GetString("SessionToken"));


                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuario(UsuarioViewModel usuario)
        {
            try
            {
                var model = new UsuarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut", "Home");

                model.Itens = await _usuarioRepository.GetUsuarioByParam(HttpContext.Session.GetString("SessionToken"), usuario.Id, usuario.Nome, usuario.IdNivelAcesso, usuario.CPF, usuario.Email, usuario.Login);
                model.ItensToPerfilSelect = await _perfilRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateUsuario(Usuario model)
        {
            try
            {
                model.Senha = "puc@2021";
                var response = _usuarioRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok(false);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdateUsuario(Usuario model)
        {
            try
            {
                var response = _usuarioRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
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
                var response = await _usuarioRepository.Delete(Id, token);
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
