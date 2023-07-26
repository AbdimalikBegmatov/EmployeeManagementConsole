using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsole
{
    public class EmployeeManagement
    {
        List<Employee> employees=new();
        int count = 0;


        public string AddEmployee()
        {
            Employee employee = new();
            employee.Id = count++;
            Console.WriteLine("Write Employee name:");
            employee.Name = Console.ReadLine().Trim();
            Console.WriteLine("Write Employee age:");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Employee position:");
            employee.Position = Console.ReadLine().Trim();

            employees.Add(employee);
            return "Employees added";
        }

        public string RemoveEmployee(int id)
        {
            var result = employees.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return "Employee not found";
            }
            employees.Remove(result);
            return "Employee deleted";
        }

        public void GetAllEmployees() {
            if (employees.Count == 0)
            {
                Console.WriteLine("Employees empty");
            }
            foreach (var item in employees)
            {
                Console.WriteLine($"Id: {item.Id} - name: {item.Name} - age: {item.Age} - position: {item.Position}");
            }
        }
    }
}
