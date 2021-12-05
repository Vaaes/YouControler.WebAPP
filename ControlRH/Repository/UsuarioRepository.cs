using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class UsuarioRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Usuario>> Get(string token)
        {
            IEnumerable<Usuario> model = new List<Usuario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Usuario");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Usuario>> GetUsuarioByParam(string token, int? id = null, string nome = null, int? IdNivelAcesso = null, string cpf = null, string email = null, string usuario = null)
        {
            IEnumerable<Usuario> ferias = new List<Usuario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Usuario/GetUsuarioByParam?id={id}&nome={nome}&IdNivelAcesso={IdNivelAcesso}&cpf={cpf}&email={email}&usuario={usuario}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(results);
            }
            return ferias;
        }

        public async Task<IEnumerable<Usuario>> GetVerificaPerfil(string token, int IdNivelAcesso)
        {
            IEnumerable<Usuario> ferias = new List<Usuario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Usuario/GetVerificaPerfil?IdNivelAcesso={IdNivelAcesso}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(results);
            }
            return ferias;
        }

        public async Task<IEnumerable<Usuario>> GetVerificaSenha(string token, int? Id)
        {
            IEnumerable<Usuario> usuario = new List<Usuario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Usuario/GetVerificaSenha?Id={Id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                usuario = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(results);
            }
            return usuario;
        }

        public bool Create(Usuario model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Usuario>("Usuario", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id, string token)
        {
            HttpClient client = _api.Initial(token);
            HttpResponseMessage res = await client.DeleteAsync($"Usuario/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Usuario>> Details(int id, string token)
        {
            IEnumerable<Usuario> model = new List<Usuario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Usuario/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(results);
            }
            return model;
        }

        public bool Update(Usuario model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Usuario>("Usuario", model);
            putTask.Wait();

            var result = putTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePassword(Usuario model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Usuario>($"Usuario/ChangePassword", model);
            putTask.Wait();

            var result = putTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
