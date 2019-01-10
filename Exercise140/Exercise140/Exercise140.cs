using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise140
{
    class Exercise140
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee(1, "Joe", "Wilson");
            Employee Employee2 = new Employee(2, "Robert", "Smith");
            Employee Employee3 = new Employee(3, "Spencer", "Cameron");
            Employee Employee4 = new Employee(4, "Shad", "Hoppeneimer");
            Employee Employee5 = new Employee(5, "Mark", "Zuck");
            Employee Employee6 = new Employee(6, "Joe", "Heiver");
            Employee Employee7 = new Employee(7, "Vanessa", "Pelkey");
            Employee Employee8 = new Employee(8, "Joe", "Reese");
            Employee Employee9 = new Employee(9, "Alex", "Saloum");
            Employee Employee10 = new Employee(10, "Ross", "Ernst");

            List<Employee> employeeList1 = new List<Employee>();
            employeeList1.Add(Employee1);
            employeeList1.Add(Employee2);
            employeeList1.Add(Employee3);
            employeeList1.Add(Employee4);
            employeeList1.Add(Employee5);
            employeeList1.Add(Employee6);
            employeeList1.Add(Employee7);
            employeeList1.Add(Employee8);
            employeeList1.Add(Employee9);
            employeeList1.Add(Employee10);

            foreach (Employee Employee in employeeList1)
            {
                Employee.printEmployee();
            }

            Console.WriteLine();

            List<Employee> employeeList2 = new List<Employee>();
            foreach (Employee Employee in employeeList1)
            {
                if (Employee.firstName == "Joe")
                {
                    employeeList2.Add(Employee);
                }
            }

            foreach (Employee Employee in employeeList2)
            {
                Employee.printEmployee();
            }

            Console.WriteLine();

            //Using lambda expression
            List<Employee> employeeList3 = new List<Employee>();
            foreach (Employee Employee in employeeList1.FindAll(x => (x.id >= 5)))
            {
                employeeList3.Add(Employee);
            }

            foreach (Employee Employee in employeeList3)
            {
                Employee.printEmployee();
            }

            Console.ReadLine();
        }
    }
}
