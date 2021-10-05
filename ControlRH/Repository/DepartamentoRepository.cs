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
    public class DepartamentoRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Departamento>> Get(string token)
        {
            IEnumerable<Departamento> Depar = new List<Departamento>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Departamento");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                Depar = JsonConvert.DeserializeObject<IEnumerable<Departamento>>(results);
            }

            return Depar;
        }

        public async Task<IEnumerable<Departamento>> GetCargoByGestorDepartamento(string token, string NomeGerente)
        {
            IEnumerable<Departamento> ferias = new List<Departamento>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Departamento/GetCargoByGestorDepartamento?NomeGerente={NomeGerente}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Departamento>>(results);
            }
            return ferias;
        }

        public bool Create(Departamento model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Departamento>("Departamento", model);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool Update(Departamento Model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Departamento>("Departamento", Model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Departamento/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Departamento>> Details(int id, string token)
        {
            IEnumerable<Departamento> Depart = new List<Departamento>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Departamento/" + id);

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                Depart = JsonConvert.DeserializeObject<IEnumerable<Departamento>>(results);
            }

            return Depart;
        }

        public async Task<IEnumerable<Colaborador>> GetGestor(string token)
        {
            IEnumerable<Colaborador> colaboradors = new List<Colaborador>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Colaborador/Gestor");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                colaboradors = JsonConvert.DeserializeObject<IEnumerable<Colaborador>>(results);
            }

            return colaboradors;
        }

        public async Task<IEnumerable<Departamento>> GetDerpWithName(string token, string Nome)
        {
            IEnumerable<Departamento> departamentos = new List<Departamento>();
            HttpClient client = _api.Initial(token);
            HttpResponseMessage res = await client.GetAsync("/Departamento/Name?Nome=" + Nome);

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                departamentos = JsonConvert.DeserializeObject<IEnumerable<Departamento>>(results);
            }

            return departamentos;

        }
    }
}
