using Principle.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Principle.API.Filters
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        /// <summary>
        /// Function delegate.
        /// </summary>
        private readonly Func<Dictionary<string, object>, bool> _validate;

        public CustomActionFilter() : this(arguments => arguments.ContainsValue(null))
        {
        }

        public CustomActionFilter(Func<Dictionary<string, object>, bool> validateActionArguments)
        {
            _validate = validateActionArguments;
        }

        public override void OnActionExecuting(HttpActionContext context)
        {
            if (_validate(context.ActionArguments))
            {
                context.Response = context.Request.CreateErrorResponse( HttpStatusCode.BadRequest, "The argument cannot be null");
            }

            if (!context.ModelState.IsValid)
            {

                context.Response = context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, context.ModelState);
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //base.OnActionExecuted(actionExecutedContext);
        }
    }
}