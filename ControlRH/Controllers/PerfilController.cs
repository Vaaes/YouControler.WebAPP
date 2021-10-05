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
        PermissoesRepository _permissoesRepository = new PermissoesRepository();
        UsuarioRepository _usuarioRepository = new UsuarioRepository();
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new PerfilViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut");

                model.itensReturnToSelect = await _perfilRepository.Get(HttpContext.Session.GetString("SessionToken"));
                model.itensReturnToTable = await _perfilRepository.Get(HttpContext.Session.GetString("SessionToken"));

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

        [HttpGet]
        public async Task<IActionResult> ListVerificaAcessoPerfil(int IdNivelAcesso)
        {
            try
            {
                var model = new UsuarioViewModel();
                if (HttpContext.Session.GetString("SessionName") == null)
                    return RedirectToAction("LogOut");

                model.Itens = await _usuarioRepository.GetVerificaPerfil(HttpContext.Session.GetString("SessionToken"), IdNivelAcesso);
                if (model.Itens.Count() > 0)
                    return Ok(false);
                return Ok(true);
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
                return Ok("Agora escolha quais menus esse perfil terá acesso:");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult CreateMenuAcessoToNewPerfil(NivelAcesso model, Permissoes modelPermissoes)
        {
            try
            {
                modelPermissoes.IdMenu = model.IdMenus;
                modelPermissoes.IdPerfilAcesso = model.IdNivelAcesso;
                var response = _nivelAcessoRepository.Create(model, HttpContext.Session.GetString("SessionToken"));
                var responsePermissions = _permissoesRepository.Create(modelPermissoes, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok("Erro ao tentar inserir Menus para o Perfil");
                return Ok("Controle de Acesso aos Menus inserido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IActionResult UpdateMenusAndPermissions(NivelAcesso model, Permissoes modelPermissoes)
        {
            try
            {
                modelPermissoes.IdMenu = model.IdMenus;
                modelPermissoes.IdPerfilAcesso = model.IdNivelAcesso;

                var response = _nivelAcessoRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
                var responsePermissions = _permissoesRepository.Update(modelPermissoes, HttpContext.Session.GetString("SessionToken"));

                if (!response)
                    return Ok("Erro ao tentar inserir Menus para o Perfil");
                return Ok("Controle de Acesso aos Menus inserido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public async Task<IActionResult> ReturnAllMenusByProfileId(int idProfile)
        {
            try
            {
                var model = await _permissoesRepository.GetMenuByProfileId(idProfile, HttpContext.Session.GetString("SessionToken"));
                return Ok(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReturnAllPermissionsByProfileId(int idProfile)
        {
            try
            {
                var model = await _permissoesRepository.GetByProfileId(idProfile, HttpContext.Session.GetString("SessionToken"));
                return Ok(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult UpdatePerfil(Perfil model)
        {
            try
            {
                var response = _perfilRepository.Update(model, HttpContext.Session.GetString("SessionToken"));
                if (!response)
                    return Ok("Erro ao tentar alterar o perfil");
                return Ok("Perfil alterado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePerfil(int Id)
        {
            try
            {
                var token = HttpContext.Session.GetString("SessionToken");

                var responsePermissoes = await _permissoesRepository.Delete(Id, token);
                var responseNivelAcesso = await _nivelAcessoRepository.Delete(Id, token);
                var response = await _perfilRepository.Delete(Id, token);
                if (!response)
                    return Ok("Erro ao tentar deletar o perfil");
                return Ok("Perfil deletado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
