using Principle.Models.Constants;
using Principle.Models.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Principle.API.Controllers
{
    public class BaseController : ApiController
    {
        internal HttpResponseMessage CreateFailResponse(Exception ex)
        {
            return Request
                    .CreateResponse(HttpStatusCode.InternalServerError,
                        new ErrorModel
                        {
                            ErrorKey = ErrorKeys.ServerError,
                            ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message
                        }, MediaTypeFormats.Json);
        }

        internal HttpResponseMessage CreatedSuccessResponse(object output, string format)
        {
            return Request.CreateResponse(HttpStatusCode.OK, output, format);
        }
    }
}
