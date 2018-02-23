using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public int ID { get; set; }
    }

    public class EmployeeAPIRS
    {
        public string Message { get; set; }

        public Status Status { get; set; }

        public HttpStatusCode HttpStatus { get; set; }
    }

    public enum Status
    {
        Failure,
        Success
    }

    public class DeleteEmployeeRS : EmployeeAPIRS
    {
        public Employee Employee { get; set; }
    }
}