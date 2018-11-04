using System;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/global")]
    public class ErrorGlobalController : BaseController
    {
        public ErrorGlobalController()
        {
            throw new NotImplementedException();
        }

        // GET: Global
        [HttpGet]
        public string Index()
        {
            return "I am in global";
        }
    }
}