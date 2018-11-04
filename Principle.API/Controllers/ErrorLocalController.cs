using System;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/local")]
    public class ErrorLocalController : BaseController
    {
        // GET: Local
        [HttpGet]
        public string Index()
        {
            throw new NotImplementedException();
        }
    }
}