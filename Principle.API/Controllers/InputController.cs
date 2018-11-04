using Principle.Models.Constants;
using Principle.Models.Enums;
using Principle.Models.ReadModels;
using Principle.Services.Entity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/input")]
    public class InputController : BaseController
    {
        #region Declaration(s)
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public InputController()
        {
        }
        #endregion

        #region Method(s)
        [HttpGet]
        public HttpResponseMessage Get(SizeType type)
        {
            //var template = (type == SizeType.Small) ? Template.MockEntityService : Template.DataEntityService;
            //var service = (IEntityService)ServiceObjectFactory.GetObject(template);

            var key = (type == SizeType.Small) ? "Mock" : "Data";
            var service = UnityConfig.GetConfiguredContainer().Resolve(typeof(IRetrieveEntityService), key) as IRetrieveEntityService;

            List<WildSearchModel> collection = service.GetNewEntities();

            return CreatedSuccessResponse(collection, MediaTypeFormats.Json);
        }

        #endregion

        #region Function(s)
        #endregion

    }
}
