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
    public class FuncionarioRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<IEnumerable<Funcionario>> Get(string token)
        {
            IEnumerable<Funcionario> model = new List<Funcionario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync("/Funcionario");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Funcionario>>(results);
            }
            return model;
        }

        public async Task<IEnumerable<Funcionario>> GetUsuarioByParam(string token, int? id = null, string nome = null, string CPF = null, string Tipo = null, string email = null, string Salario = null, int? IdCargo = null)
        {
            IEnumerable<Funcionario> ferias = new List<Funcionario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Funcionario/GetFuncionarioByParam?id={id}&nome={nome}&CPF={CPF}&Tipo={Tipo}&email={email}&Salario={Salario}&IdCargo={IdCargo}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                ferias = JsonConvert.DeserializeObject<IEnumerable<Funcionario>>(results);
            }
            return ferias;
        }

        public bool Create(Funcionario model, string token)
        {
            HttpClient client = _api.Initial(token);

            var postTask = client.PostAsJsonAsync<Funcionario>("Funcionario", model);
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
            HttpResponseMessage res = await client.DeleteAsync($"Funcionario/{id}");
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Funcionario>> Details(int id, string token)
        {
            IEnumerable<Funcionario> model = new List<Funcionario>();
            HttpClient client = _api.Initial(token);

            HttpResponseMessage res = await client.GetAsync($"/Funcionario/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<IEnumerable<Funcionario>>(results);
            }
            return model;
        }

        public bool Update(Funcionario model, string token)
        {
            HttpClient client = _api.Initial(token);

            var putTask = client.PutAsJsonAsync<Funcionario>("Funcionario", model);
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
