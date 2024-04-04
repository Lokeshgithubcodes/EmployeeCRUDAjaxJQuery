using BusinessLayer.Interfaces;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmployeeBusiness:IEmployeeBusiness
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public object GetUserDetails()
        {
            return employeeRepository.GetUserDetails();
        }
    }
}
