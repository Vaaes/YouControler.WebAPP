using ControlRH.Models;
using ControlRH.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Controllers
{
    public class PerfilController : Controller
    {
        LogInRepository _login = new LogInRepository();
        PerfilRepository _perfilRepository = new PerfilRepository();
        NivelAcessoRespository _nivelAcessoRepository = new NivelAcessoRespository();
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new PerfilViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut");

                model.itensReturnToSelect = await _perfilRepository.Get(HttpContext.Session.GetString("SessionToken"));

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> ListRoleBySearch(PerfilViewModel perfil)
        {
            try
            {
                var model = new PerfilViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut");

                model.itensReturnToSelect = await _perfilRepository.Get(HttpContext.Session.GetString("SessionToken"));
                model.itensReturnToTable = await _perfilRepository.GetById(HttpContext.Session.GetString("SessionToken"), perfil.Id);

                return View("Index", model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> ListRoleByName(string Role)
        {
            try
            {
                var model = await _perfilRepository.GetByRole(HttpContext.Session.GetString("SessionToken"), Role);
                return Ok(model.First().Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReturnAllMenusToModal()
        {
            try
            {
                var model = await _login.GetAllMenus(HttpContext.Session.GetString("SessionToken"));
                return Ok(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateNewPerfil(Perfil model)
        {
            try
            {
                var response = _perfilRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok("Erro ao tentar inserir Perfil");
                return Ok("Perfil inserido com sucesso! Agora, escolha quais menus esse perfil terá acesso:");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateMenuAcessoToNewPerfil(NivelAcesso model)
        {
            try
            {
                var response = _nivelAcessoRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok("Erro ao tentar inserir Menus para o Perfil");
                return Ok("Controle de Acesso aos Menus inserido com sucesso! Agora, escolha quais Permissões esse perfil terá acesso:");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult DeletePerfil(NivelAcesso model)
        {
            try
            {
                


                return Ok("Perfil deletado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
