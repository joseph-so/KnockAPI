using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnockAPI.Controllers
{
    public class TokenController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "d51aaed6-c81c-42b7-a4e6-f337dfacc308");
        }
    }
}
