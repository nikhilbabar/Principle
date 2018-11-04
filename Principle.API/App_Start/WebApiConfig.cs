using Newtonsoft.Json.Serialization;
using Principle.API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Principle.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new CustomActionFilter());
            config.Filters.Add(new CustomExceptionFilterAttribute());
            config.Services.Replace(typeof(IExceptionHandler), new CustomExceptionFilter());
            config.Services.Replace(typeof(IExceptionLogger), new CustomExceptionLogger());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /// To make json response property into the camel case format
            //var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault();
            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
