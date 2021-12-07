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
    public class CandidatosRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Candidatos>> Get(string token)
        {
            IEnumerable<Candidatos> model = new List<Candidatos>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Candidatos");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Candidatos>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Candidatos>> GetCandidatosByParam(string token, int? id = null, string NomeCandidato = null, int? IdadeCandidato = null, string EmailCandidato = null, string TelefoneCandidato = null, int? IdVaga = null)
        {
            IEnumerable<Candidatos> ferias = new List<Candidatos>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Candidatos/GetCandidatosByParam?id={id}&NomeCandidato={NomeCandidato}&IdadeCandidato={IdadeCandidato}&EmailCandidato={EmailCandidato}&TelefoneCandidato={TelefoneCandidato}&IdVaga={IdVaga}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Candidatos>>(results);
            }
            return ferias;
        }

        public bool Create(Candidatos model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Candidatos>("Vagas", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Candidatos/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Candidatos>> Details(int id, string token)
        {
            IEnumerable<Candidatos> model = new List<Candidatos>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Candidatos/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Candidatos>>(results);
            }
            return model;
        }

        public bool Update(Candidatos model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Candidatos>("Candidatos", model);
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
