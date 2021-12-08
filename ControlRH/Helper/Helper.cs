using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ControlRH.Helper
{
    public class RhAPI
    {
        public HttpClient Initial(string token)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.rhcontrol-api.online/");
            //client.BaseAddress = new Uri("https://localhost:44303/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return client;
        }
    }
}
