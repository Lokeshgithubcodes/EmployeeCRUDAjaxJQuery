using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly Context context;

        public EmployeeRepository(Context context)
        {
            this.context = context;
        }

        public object GetUserDetails()
        {
            var data=context.Employees.ToList();

            if (data == null)
            {
                return null;
            }
            return data;
        }
    }
}
