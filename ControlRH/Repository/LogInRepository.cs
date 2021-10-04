using ControlRH.Helper;
using ControlRH.Models;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class LogInRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<Usuario> Details(Usuario user)
        {
            Usuario model = new Usuario();
            var client = new HttpClient();
            //client.BaseAddress = new Uri("http://www.rhcontrol-api.online/");
            client.BaseAddress = new Uri("https://localhost:44303/");
        

            HttpResponseMessage res = await client.PostAsJsonAsync<Usuario>($"/LogIn/Auth", user);
            if (res.IsSuccessStatusCode)
            {
                string results = res.Content.ReadAsStringAsync().Result;
                model = new JavaScriptSerializer().Deserialize<Usuario>(results);
            }

            return model;
        }

        public async Task<IEnumerable<ControleAcesso>> Get(string token, int? id)
        {
            IEnumerable<ControleAcesso> model = new List<ControleAcesso>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/LogIn/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<ControleAcesso>>(results);
            }

            return model;
        }
        public async Task<IEnumerable<Menus>> GetAllMenus(string token)
        {
            IEnumerable<Menus> model = new List<Menus>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Menu");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Menus>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Permissoes>> HasPermission(string token, int? id, int IdMenu)
        {
            IEnumerable<Permissoes> model = new List<Permissoes>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Permissoes/{id}/{IdMenu}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Permissoes>>(results);
            }

            ////Me perdoem, eu fui obrigado a fazer isso
            //if (Method == "criar") { if (model.First().CRIAR == 1) { return true; } }
            //if (Method == "ler") { if (model.First().LER == 1) { return true; } }
            //if (Method == "alterar") { if (model.First().ALTERAR == 1) { return true; } }
            //if (Method == "deletar") { if (model.First().DELETAR == 1) { return true; } }

            return model;
        }
    }
}
