using System;
using System.Collections.Generic;
using System.Text;

namespace Entityfarmework
{
   internal interface IEmployeeRepo
    {
        Employee Create(string firstName,
            string lastName,
            string address, 
            string homeAddress, 
            int cellphone);
        Employee Update(Employee employee);
        void Delete(Employee employee);
            
    }
}
