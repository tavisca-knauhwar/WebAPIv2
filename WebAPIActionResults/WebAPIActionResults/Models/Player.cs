using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebAPIActionResults.Models
{
    public class Player : Person
    {
        public string Sport { get; set; }
    }

    public class FootballPlayer : Player, IHttpActionResult
    {
        public PlayerFieldPosition PlayerFieldPosition { get; set; }
        public PlayerPosition PlayerPosition { get; set; }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent("Kuldeep Singh")
            };

            return Task.FromResult(response);
        }
    }

    public enum PlayerPosition
    {
        Defence,
        Midfield,
        Attack,
        All,
        GK
    }

    public enum PlayerFieldPosition
    {
        Left,
        Right,
        Center,
        All,
        None
    }

}