using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnockAPI.Controllers
{
    
    public class TriangleTypeController : ApiController
    {
        public HttpResponseMessage Get([FromUri] Models.Triangle t)
        {

            return Request.CreateResponse(HttpStatusCode.OK, t.isTriangle());
        }
    }
}
