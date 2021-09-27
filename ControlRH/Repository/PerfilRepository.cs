using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class PerfilRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Perfil>> Get(string token)
        {
            IEnumerable<Perfil> model = new List<Perfil>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Perfil");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Perfil>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Perfil>> GetById(string token, int? id)
        {
            IEnumerable<Perfil> model = new List<Perfil>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Perfil/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Perfil>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Perfil>> GetByRole(string token, string Role)
        {
            IEnumerable<Perfil> model = new List<Perfil>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Perfil/" + Role);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Perfil>>(results);
            }
            return model;
        }

        public bool Create(Perfil model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Perfil>("Perfil", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool Update(Perfil model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Perfil>("Perfil", model);
            putTask.Wait();

            var result = putTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id, string token)
        {
            HttpClient client = _api.Initial(token);
            HttpResponseMessage res = await client.DeleteAsync($"Perfil/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
