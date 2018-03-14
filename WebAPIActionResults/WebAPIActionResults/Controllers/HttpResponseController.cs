using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIActionResults.Controllers
{
    public class HttpResponseController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content =new StringContent( string.Format("{0}{1}", response.Content.ToString(), "honor"));
            return response;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
