using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEx
{
    internal class Employee 
    { 
        
        public string name;
        public string id;
        public string position;
        public double salary;

        public Employee()
        {
            this.name = string.Empty;
            this.id = string.Empty;
            this.position = string.Empty;
            this.salary = 0;
        }

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{name} : {id} : {position} : {salary}");
        }
        

        public void CompareSalary(Employee employee)
        {
            double erotus = (salary - employee.salary) / employee.salary * 100;
            if (salary > employee.salary)
            {
                Console.WriteLine($"{name} earns {erotus:F2} % more than " + employee.name);
            }
            else if (salary == employee.salary) 
            {
                Console.WriteLine($"{name} earns the same as " + employee.name);
            }
            else if (salary < employee.salary)
            {
                Console.WriteLine($"{name} earns {erotus*-1:F2} % less than " + employee.name);
            }
            
            else
            {
                Console.WriteLine("Information is invalid");
            }
        }

        public override string? ToString()
        {
            return $"{name} : {id} : {position} : {salary}";
        }
    }

    

}
