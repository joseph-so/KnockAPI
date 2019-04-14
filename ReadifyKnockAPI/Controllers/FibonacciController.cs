using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnockAPI.Controllers
{
    

    public class FibonacciController : ApiController
    {
        // GET api/Fibonaaci
        public HttpResponseMessage Get(string n = "0")
        {
            long input;
            if (long.TryParse(n, out input))
                try {
                    return Request.CreateResponse(HttpStatusCode.OK, Models.Fibonacci.GetNthFibonacci(input));
                } catch
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, new HttpError());
                }
                

            var message = "The request is invalid.";
            HttpError err =  new HttpError(message);
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, err);
        }
    }
}
