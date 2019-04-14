using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnockAPI.Controllers
{
    public class ReverseWordsController : ApiController
    {
        public HttpResponseMessage Get(string sentence = "")
        {
            if (sentence == null)
            {
                var message = "The request is invalid.";
                HttpError err = new HttpError(message);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, err);
            }

            if (sentence == "")
                return Request.CreateResponse(HttpStatusCode.OK, "");
            return Request.CreateResponse(HttpStatusCode.OK, string.Join(" ", sentence.Split(' ').Select(s => new String(s.Reverse().ToArray()))));
        }
    }
}
