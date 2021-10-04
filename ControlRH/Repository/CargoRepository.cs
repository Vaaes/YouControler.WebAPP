using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class CargoRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Cargo>> Get(string token)
        {
            IEnumerable<Cargo> cargos = new List<Cargo>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Cargo");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cargos = JsonConvert.DeserializeObject<IEnumerable<Cargo>>(results);
            }
            return cargos;
        }

        public bool Create(Cargo model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Cargo>("Cargo", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Cargo>> GetCargoByParam(string token, string Nome_Cargo = null)
        {
            IEnumerable<Cargo> cargo = new List<Cargo>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Cargo/GetCargoByName?Nome={Nome_Cargo}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cargo = JsonConvert.DeserializeObject<IEnumerable<Cargo>>(results);
            }
            return cargo;
        }

        public async Task<bool> Delete(int id, string token)
        {
            HttpClient client = _api.Initial(token);
            HttpResponseMessage res = await client.DeleteAsync($"Cargo/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Cargo>> Details(int id, string token)
        {
            IEnumerable<Cargo> cargos = new List<Cargo>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Cargo/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cargos = JsonConvert.DeserializeObject<IEnumerable<Cargo>>(results);
            }
            return cargos;
        }

        public bool Update(Cargo model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Cargo>("Cargo", model);
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