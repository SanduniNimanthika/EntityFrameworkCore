using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entityfarmework
{
    class EmployeeProvider :IEmployeeProvider
    {
        private readonly EmployeeContent employeeContent;
         
        public EmployeeProvider(EmployeeContent employeeContent)
        {
            this.employeeContent = employeeContent;
        }

        public Employee Get(int id )
        {
            return employeeContent.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
 