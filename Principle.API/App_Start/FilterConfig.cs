using Principle.API.Filters;
using System.Web.Mvc;

namespace Principle.API
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionFilterAttribute());
        }
    }
}