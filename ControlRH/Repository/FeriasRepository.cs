using ControlRH.Helper;
using ControlRH.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class FeriasRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Ferias>> Get(string token)
        {
            IEnumerable<Ferias> ferias = new List<Ferias>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Ferias");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Ferias>>(results);
            }
            return ferias;
        }

        public async Task<IEnumerable<Ferias>> GetFeriasByParam(string token, string Data_Inicio = null, string Data_Final = null, int? Id = null,  int? IdUsuario = null, bool? Aprovado = null)
        {
            IEnumerable<Ferias> ferias = new List<Ferias>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Ferias/GetByParam?data_Inicio={Data_Inicio}&data_Final={Data_Final}&IdUsuario={IdUsuario}&aprovado={Aprovado}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Ferias>>(results);
            }
            return ferias;
        }

        public bool Create(Ferias model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Ferias>("Ferias", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Ferias/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool Update(Ferias model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Ferias>("Ferias", model);
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
