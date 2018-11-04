using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace Principle.API.Filters
{
    public class CustomAuthenticationFilter : IAuthenticationFilter
    {
        public bool AllowMultiple
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}