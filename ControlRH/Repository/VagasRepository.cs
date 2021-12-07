using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class VagasRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Vagas>> Get(string token)
        {
            IEnumerable<Vagas> model = new List<Vagas>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Vagas");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Vagas>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Vagas>> GetVagasByParam(string token, int? id = null, string NomeVaga = null, string DataMaxima = null, string PerfilVaga = null)
        {
            IEnumerable<Vagas> ferias = new List<Vagas>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Vagas/GetVagasByParam?id={id}&NomeVaga={NomeVaga}&DataMaxima={DataMaxima}&PerfilVaga={PerfilVaga}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Vagas>>(results);
            }
            return ferias;
        }

        public bool Create(Vagas model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Vagas>("Vagas", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Vagas/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Vagas>> Details(int id, string token)
        {
            IEnumerable<Vagas> model = new List<Vagas>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Vagas/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Vagas>>(results);
            }
            return model;
        }

        public bool Update(Vagas model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Vagas>("Vagas", model);
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
