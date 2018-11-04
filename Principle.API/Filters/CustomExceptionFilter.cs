using Principle.Models.Constants;
using Principle.Models.ReadModels;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
namespace Principle.API.Filters
{
    /// <summary>
    /// Filter handled uncaught exceptions thrown from controller.
    /// Use Exception Filters to deal with particular unhandled exceptions on multiple actions and controllers.
    /// </summary>
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            /// https://docs.microsoft.com/en-us/aspnet/web-api/overview/error-handling/exception-handling
            var exception = context.Exception;
            var statusCode = HttpStatusCode.InternalServerError;

            if (exception is ArgumentException)
            {
                statusCode = HttpStatusCode.BadGateway;
            }
            if (exception is NotImplementedException)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }

            context.Response = context.Request
                          .CreateResponse(statusCode,
                                            new ErrorModel
                                            {
                                                ErrorKey = ErrorKeys.ServerError,
                                                ErrorMessage = "This local error filter attribute."
                                                //ErrorMessage = exception.InnerException != null ?
                                                //                    exception.InnerException.Message :
                                                //                        exception.Message
                                            }, MediaTypeFormats.Json);

        }
    }

    /// <summary>
    /// Use Exception Handlers (one per application) to deal with any unhandled exception application-wide.
    /// 1. Exceptions thrown from controller constructors.
    /// 2. Exceptions thrown from message handlers.
    /// 3. Exceptions thrown during routing.
    /// 4. Exceptions thrown during response content serialization.
    /// </summary>
    public class CustomExceptionFilter : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            /// https://www.exceptionnotfound.net/the-asp-net-web-api-exception-handling-pipeline-a-guided-tour/
            var exception = context.Exception as Exception;

            var result = context.Request.CreateResponse(HttpStatusCode.InternalServerError,
                                            new ErrorModel
                                            {
                                                ErrorKey = ErrorKeys.ServerError,
                                                ErrorMessage = "This global error filter handler."
                                                //ErrorMessage = exception.InnerException != null ?
                                                //                    exception.InnerException.Message :
                                                //                        exception.Message
                                            }, MediaTypeFormats.Json);

            context.Result = new CustomExceptionResult(context.Request, result);

        }
    }

    public class CustomExceptionResult : IHttpActionResult
    {
        private HttpRequestMessage _request;
        private HttpResponseMessage _httpResponseMessage;

        public CustomExceptionResult(HttpRequestMessage request, HttpResponseMessage httpResponseMessage)
        {
            _request = request;
            _httpResponseMessage = httpResponseMessage;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_httpResponseMessage);
        }
    }

    public class CustomExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            var log = context.Exception.ToString();
            //Do whatever logging you need to do here.
        }
    }
}