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

        public async Task<IEnumerable<Usuario>> Get()
        {
            IEnumerable<Usuario> model = new List<Usuario>();
            HttpClient client = _api.Initial();

            HttpResponseMessage res = await client.GetAsync("/Usuario");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(results);
            }

            return model;
        }

        public bool Create(Usuario model)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<Usuario>("Usuario", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"Usuario/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Usuario>> Details(int id)
        {
            IEnumerable<Usuario> model = new List<Usuario>();
            HttpClient client = _api.Initial();

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
