using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class PermissoesRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Permissoes>> Get(string token)
        {
            IEnumerable<Permissoes> model = new List<Permissoes>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Permissoes");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Permissoes>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Permissoes>> GetById(string token, int? id)
        {
            IEnumerable<Permissoes> model = new List<Permissoes>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Permissoes/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Permissoes>>(results);
            }
            return model;
        }
        public async Task<IEnumerable<Permissoes>> GetByProfileId(int ProfileId, string token)
        {
            IEnumerable<Permissoes> model = new List<Permissoes>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Permissoes/GetByProfile/" + ProfileId);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Permissoes>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Menus>> GetMenuByProfileId(int ProfileId, string token)
        {
            IEnumerable<Menus> model = new List<Menus>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Menu/GetByProfile/" + ProfileId);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Menus>>(results);
            }
            return model;
        }


        public bool Create(Permissoes model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Permissoes>("Permissoes", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool Update(Permissoes model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Permissoes>("Permissoes", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Permissoes/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
