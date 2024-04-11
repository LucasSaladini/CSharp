using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace curso.web.mvc.Handler
{
    public class BearerTokenMessageHandler : DelegatingHandler
    {
        private readonly IHttpContextAccessor _httpContextAcessor;
        public BearerTokenMessageHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAcessor = httpContextAccessor;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(request?.Headers?.Authorization != null)
            {
                var token = _httpContextAcessor.HttpContext.User.FindFirst("token").Value;
                request.Headers.Authorization = new AuthenticationHeaderValue(request.Headers.Authorization.Scheme, token);

            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}