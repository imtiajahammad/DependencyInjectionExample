using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Constructor Dependency Injection Design Pattern*/
            Console.WriteLine("--------------------Constructor Dependency Injection Design Pattern--------------------");
            /*https://dotnettutorials.net/lesson/dependency-injection-design-pattern-csharp/*/
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            /*Constructor Dependency Injection Design Pattern*/
            Console.WriteLine("--------------------Property and Method Dependency Injection Design Pattern--------------------");
            /*https://dotnettutorials.net/lesson/setter-dependency-injection-design-pattern-csharp/*/
            /*Property Dependency Injection Design Pattern*/
            EmployeeBL2 employeeBL2 = new EmployeeBL2();
            employeeBL2.employeeDataObject = new EmployeeDAL();

            List<Employee> ListEmployee2 = employeeBL2.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            /*Property Dependency Injection Design Pattern*/


            /*Method Dependency Injection Design Pattern*/
            Console.WriteLine("--------------------Method Dependency Injection Design Pattern--------------------");
            /*https://dotnettutorials.net/lesson/setter-dependency-injection-design-pattern-csharp/*/
            //Create object of EmployeeBL class
            EmployeeBL3 employeeBL3 = new EmployeeBL3();
            //Call to GetAllEmployees method with proper object.            
            List<Employee> ListEmployee3 = employeeBL3.GetAllEmployees(new EmployeeDAL());
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            /*Method Dependency Injection Design Pattern*/

            Console.ReadKey();
        }
    }
}
