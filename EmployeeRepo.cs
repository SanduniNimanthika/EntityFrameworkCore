using System;
using System.Collections.Generic;
using System.Text;

namespace Entityfarmework
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContent employeeContent;


        public EmployeeRepo(EmployeeContent employeeContent)
        { 
            this.employeeContent = employeeContent;
        }
        public Employee Create(string firstName,
            string lastName,
            string address, 
            string homeAddress,
            int cellphone)
        {
            var response = employeeContent.Add(new Employee
            {
                FristName = firstName,
                LastName = lastName,
                Address = address,
                HomeAddress = homeAddress,
                Cellphone = cellphone
            }
            );
            employeeContent.SaveChanges();
            return response.Entity; 

        }

        public void Delete(Employee employee)
        {
            employeeContent.Remove(employee);
            employeeContent.SaveChanges(); 

        }

        public Employee Update(Employee employee)
        {
          var response=  employeeContent.Update(employee);
            employeeContent.SaveChanges();
            return response.Entity;
        }
    }
}
 