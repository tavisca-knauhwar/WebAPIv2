using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagementAPI.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        public static List<Models.Employee> employeeLst = InitEmployeeList();

        [NonAction]
        public static List<Models.Employee> InitEmployeeList()
        {
            var employeeLst = new List<Models.Employee>();
            employeeLst.Add(new Models.Employee() { Name = "Ravnit", ID = 1 });
            employeeLst.Add(new Models.Employee() { Name = "Kuldeep", ID = 2 });
            employeeLst.Add(new Models.Employee() { Name = "NimDeep", ID = 3 });
            return employeeLst;
        }

        [HttpGet]
        [Route("getemployees")]
        public List<Models.Employee> Employees()
        {
            return employeeLst;
        }

        [HttpGet]
        [Route("getfirstemployee")]
        public Models.Employee FirstEmployee()
        {
            return employeeLst.First();
        }

        [HttpPost]
        [Route("addemployee")]
        public Models.EmployeeAPIRS AddEmployee([FromBody]Models.Employee employee)
        {
            try
            {
                if (employee == null || string.IsNullOrEmpty(employee.Name) || employee.ID == 0)
                    return new Models.EmployeeAPIRS
                    {
                        Message = "Invalid employee parameter",
                        Status = Models.Status.Failure,
                        HttpStatus = HttpStatusCode.BadRequest
                    };
                employeeLst.Add(employee);
                return new Models.EmployeeAPIRS
                {
                    Message = "Employee successfully added",
                    Status = Models.Status.Success,
                    HttpStatus = HttpStatusCode.Created
                };
            }
            catch (Exception)
            {
                return new Models.EmployeeAPIRS
                {
                    Message = "Error occured while processing your request",
                    Status = Models.Status.Failure,
                    HttpStatus = HttpStatusCode.InternalServerError
                };

            }
        }

        [HttpDelete]
        [Route("removeEmployee/{employeeID}")]
        public Models.DeleteEmployeeRS RemoveEmployee(int employeeID)
        {
            try
            {
                var employee = employeeLst.FirstOrDefault(employe => employe.ID == employeeID);
                employeeLst.RemoveAll(empl => empl.ID == employeeID);
                return new Models.DeleteEmployeeRS
                {
                    Message = "Employee fired successfully",
                    Status = Models.Status.Success,
                    HttpStatus = HttpStatusCode.Gone,
                    Employee = employee
                };
            }
            catch (Exception)
            {
                return new Models.DeleteEmployeeRS
                {
                    Message = "Employee with given ID not found",
                    Status = Models.Status.Failure,
                    HttpStatus = HttpStatusCode.NotFound,
                    Employee = null
                };
            }
        }
    }
}
