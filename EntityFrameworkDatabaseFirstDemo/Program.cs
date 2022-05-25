using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GN22ADMDNF001Entities context = new GN22ADMDNF001Entities(); //create object of DbContext class

            // we use Ienumerable for collection simillarly IQuerable is for database 
            IQueryable<ClsEmployee> employees = context.ClsEmployees;

            foreach(ClsEmployee employee in employees)
            {
                Console.WriteLine("FirstName=" + employee.FirstName);
                Console.WriteLine("LastName=" + employee.LastName);
                Console.WriteLine("Password=" + employee.Password);
                Console.WriteLine("Email=" + employee.Email);
                Console.WriteLine("Cell=" + employee.CellNumber);    Console.WriteLine("*****");
                Console.WriteLine();
                Console.ReadLine();    
            }
        }
    }
}
