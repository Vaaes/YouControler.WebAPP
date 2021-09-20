﻿using ControlRH.Helper;
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

        public async Task<IEnumerable<Cargo>> Get()
        {
            IEnumerable<Cargo> cargos = new List<Cargo>();
            HttpClient client = _api.Initial();

            HttpResponseMessage res = await client.GetAsync("/Cargo");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cargos = JsonConvert.DeserializeObject<IEnumerable<Cargo>>(results);
            }

            return cargos;
        }

        public bool Create(Cargo model)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<Cargo>("Cargo", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Cargo/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Cargo>> Details(int id)
        {
            IEnumerable<Cargo> cargos = new List<Cargo>();
            HttpClient client = _api.Initial();

            HttpResponseMessage res = await client.GetAsync($"/Cargo/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cargos = JsonConvert.DeserializeObject<IEnumerable<Cargo>>(results);
            }

            return cargos;
        }
    }
}
