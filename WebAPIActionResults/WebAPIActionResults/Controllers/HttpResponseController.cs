using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace WebAPIActionResults.Controllers
{
    public class HttpResponseController : ApiController
    {
        // GET api/values

        public static List<Models.FootballPlayer> footballPlayers;

        public HttpResponseController()
        {
            footballPlayers = new List<Models.FootballPlayer>();
            footballPlayers.Add(new Models.FootballPlayer()
            {
                BloodGroup=new Models.BloodGroup (){BloodType=Models.BloodType.O,BloodTypeSign=Models.BloodTypeSign.Positive },
                Height = 5.7m,
                Weight=67,
                Name="Kuldeep Singh"
            });
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public HttpResponseMessage GetResponseViaCreateResponse(int id)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, footballPlayers.First());
            
            return response;
        }

        public HttpResponseMessage GetResponseViaHttpResponseObject(int id)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            //response.Content = new ObjectContent(typeof(Models.FootballPlayer), footballPlayers.First(),);s
            return response;
        }

        public IHttpActionResult GetResponseViaIHttpActionObject(int id)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            //response.Content = new ObjectContent(typeof(Models.FootballPlayer), footballPlayers.First(),);s
            return new Models.FootballPlayer();
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
