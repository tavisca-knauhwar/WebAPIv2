using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {

        public static List<Models.Employee> employeeLst = InitEmployeeList();

        private static List<Models.Employee> InitEmployeeList()
        {
            var employees = new List<Models.Employee>();

            employees.Add(new Models.Employee() { Name = "Ravnit", EmployeeID = 1 });
            employees.Add(new Models.Employee() { Name = "Kuldeep", EmployeeID = 2 });
            employees.Add(new Models.Employee() { Name = "NimDeep", EmployeeID = 3 });

            return employees;
        }

        [Route("getemployees")]
        public List<Models.Employee> GetEmployees()
        {
            return employeeLst;
        }

        [Route("getemployee/{id:int=1}")]

        public Models.Employee GetEmployee(int id)
        {
            return employeeLst.FirstOrDefault(employee => employee.EmployeeID == id);
        }

        [Route("GetSingleEmployee/{id:int=1}")]

        public Models.Employee GetSingleEmployee(int id)
        {
            return employeeLst.FirstOrDefault(employee => employee.EmployeeID == id);
        }
        [Route("GetSingleEmployee")]

        public Models.Employee GetSingleEmployee()
        {
            return employeeLst.FirstOrDefault();
        }


    }
}
