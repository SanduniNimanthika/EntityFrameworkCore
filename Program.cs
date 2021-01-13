using System;

namespace Entityfarmework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContent("Data Source=DESKTOP-57GTGLQ\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
            var provider = new EmployeeProvider(context);
             
            var employee = provider.Get(2);
            Console.WriteLine($"welcome{employee.FristName}{employee.LastName}");

            var repo = new EmployeeRepo(context);
     
            var emplyee1 = provider.Get(2);
            
            emplyee1.FristName = "NewFirst";
            repo.Update(emplyee1);
            repo.Delete(emplyee1);


                
       
        }

    }
}
