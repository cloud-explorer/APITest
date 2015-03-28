using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APITestApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var strings = new[] { "value1", "value2" };
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, strings);
            return response;
        }

        // GET api/values/5
        public HttpResponseMessage GetById(HttpRequestMessage request, int id)
        {
            string s = "value";
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, s);
            return response;
        }

       
    }
}
