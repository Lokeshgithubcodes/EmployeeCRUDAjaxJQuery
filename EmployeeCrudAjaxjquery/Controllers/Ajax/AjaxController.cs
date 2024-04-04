using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using RepositoryLayer.Entity;
using System.Linq;

namespace EmployeeCrudAjaxjquery.Controllers.Ajax
{
    public class AjaxController : Controller
    {

        private readonly Context context;
        private readonly IEmployeeBusiness employeeBusiness;

        public AjaxController(Context context, IEmployeeBusiness employeeBusiness)
        {
            this.context = context;
            this.employeeBusiness = employeeBusiness;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public JsonResult EmployeeList()
        {
            var data=this.context.Employees.ToList();
            return new JsonResult(data);
        }

        [HttpPost]

        public JsonResult AddEmployee(Employee employee)
        {
			Employee emp = new Employee()
			{
				Name = employee.Name,
				City = employee.City,
				State = employee.State,
				Salary = employee.Salary,
			};
			this.context.Employees.Add(emp);
			this.context.SaveChanges();
			return new JsonResult("Data is Saved");
		}

        public JsonResult Delete(int id)
        {
            var data = this.context.Employees.Where(e => e.Id == id).SingleOrDefault();
            this.context.Employees.Remove(data);
            this.context.SaveChanges();
            return new JsonResult("Data Delted");
        }

        public JsonResult Edit(int id)
        {
            var data = this.context.Employees.Where(e => e.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Update(Employee employee)
        {
            this.context.Employees.Update(employee);
            this.context.SaveChanges();
            return new JsonResult("Record updated")
;
        }
    }

}
