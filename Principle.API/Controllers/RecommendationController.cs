using Principle.Models.CommandModels;
using Principle.Models.Constants;
using Principle.Models.ReadModels;
using Principle.Services.Entity;
using Principle.Services.Recommendation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Principle.API.Controllers
{
    [RoutePrefix("api/recommendation")]
    public class RecommendationController : BaseController
    {
        #region Declaration(s)
        private readonly IRecommendationService _recommendationService;
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public RecommendationController(IRecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }
        #endregion

        #region Method(s)
        [HttpPost]
        public HttpResponseMessage Fetch(RecommendationCommandModel model)
        {
            try
            {
                var recommendations = _recommendationService.GetRecommendation(model.Type, model.Collection);
                var successResponse =
                    Request.CreateResponse(HttpStatusCode.OK, recommendations, MediaTypeFormats.Json);

                return successResponse;
            }
            catch (Exception ex)
            {
                return CreateFailResponse(ex);
            }
        }
        #endregion

        #region Function(s)
        #endregion
    }
}
