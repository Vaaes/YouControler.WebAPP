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
    }
}
