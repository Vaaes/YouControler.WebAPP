using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlRH.Controllers
{
    public class BaseController : Controller
    {
        public string SessionToken;

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
