using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlRH.Controllers
{
    public class BaseController : Controller
    {
        public string SessionToken;
        public const string MyProperty = "ExecutadoComSucesso";

        //public BaseController()
        //{
        //    returnToken();
        //}

        public string returnToken()
        {
            return HttpContext.Session.GetString("SessionToken");
        }
    }
}
