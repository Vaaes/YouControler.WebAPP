using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class NivelAcessoRespository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<NivelAcesso>> Get(string token)
        {
            IEnumerable<NivelAcesso> model = new List<NivelAcesso>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/NivelAcesso");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<NivelAcesso>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<NivelAcesso>> GetById(string token, int? id)
        {
            IEnumerable<NivelAcesso> model = new List<NivelAcesso>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/NivelAcesso/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<NivelAcesso>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<NivelAcesso>> GetByRole(string token, string Role)
        {
            IEnumerable<NivelAcesso> model = new List<NivelAcesso>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/NivelAcesso/" + Role);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<NivelAcesso>>(results);
            }
            return model;
        }

        public bool Create(NivelAcesso model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<NivelAcesso>("NivelAcesso", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool Update(NivelAcesso model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<NivelAcesso>("NivelAcesso", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"NivelAcesso/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
