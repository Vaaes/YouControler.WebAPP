using ControlRH.Helper;
using ControlRH.Models;
using Nancy.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControlRH.Repository
{
    public class LogInRepository
    {
        RhAPI _api = new RhAPI();

        public async Task<Usuario> Details(Usuario user)
        {
            Usuario model = new Usuario();
            HttpClient client = _api.Initial();

            HttpResponseMessage res = await client.PostAsJsonAsync<Usuario>($"/LogIn/Auth", user);
            if (res.IsSuccessStatusCode)
            {
                string results = res.Content.ReadAsStringAsync().Result;
                //model = JsonConvert.DeserializeObject(results);
                model = new JavaScriptSerializer().Deserialize<Usuario>(results);
                //model = JsonConvert.DeserializeObject<UsuarioToken>(results);
            }

            return model;
        }
    }
}
