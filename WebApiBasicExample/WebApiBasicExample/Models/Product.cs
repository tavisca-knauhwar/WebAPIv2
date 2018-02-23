using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiBasicExample.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class PostResponse
    {
        public Status Status { get; set; }
        public string Message { get; set; }
    }

    public enum Status
    {
        Success,
        Warning,
        Failure,
        Error
    }
}