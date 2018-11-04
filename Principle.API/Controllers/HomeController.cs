using Principle.Models.Constants;
using Principle.Models.ReadModels;
using Principle.Services.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : BaseController
    {
        #region Declaration(s)
        IRetrieveEntityService entityService;
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public HomeController()
        {
            entityService = new MockEntityService();
        }
        #endregion

        #region Method(s)
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            try
            {
                var collection = entityService.GetNewEntities();
                var successResponse = Request.CreateResponse<List<WildSearchModel>>(HttpStatusCode.OK, collection, MediaTypeFormats.Json);

                return successResponse;
            }
            catch (Exception ex)
            {
                return CreateFailResponse(ex);
            }
        }

        //[HttpGet]
        //[Route("")]
        //public HttpResponseMessage Get()
        //{
        //    try
        //    {
        //        var collection = entityService.GetMasterEntities();
        //        var successResponse =
        //            this.Request.CreateResponse<List<WildSearchModel>>(HttpStatusCode.OK, collection, MediaTypeFormats.Json);

        //        return successResponse;
        //    }
        //    catch (Exception ex)
        //    {
        //        return CreateErrorResponse(ex);
        //    }
        //}
        #endregion

        #region Function(s)
        #endregion
    }

}
