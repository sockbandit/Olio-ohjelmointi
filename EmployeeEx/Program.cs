namespace EmployeeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

             

            Employee[] employees = new Employee[3];     //Taulukko työntekijöille
            employees[0] = new Employee("Kasper Kaarna", "1", "CEO, COO, Millionaire", 6000);
            employees[1] = new Employee("Kasperi Nyrkkö", "2", "Truck Driver", 3500);
            employees[2] = new Employee("Mikko Pakarinen", "3", "Toilet Cleaner", 3000);
             
            Console.ForegroundColor = ConsoleColor.Red;  //Vaihdetaan väriä punaiseksi otsikkoon
            Console.WriteLine("Employee salaries and titles");
            Console.ResetColor();
            foreach (Employee employee in employees)  //Käydään läpi työntekijätaulukko ja tiedot
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Salary comparison");
            Console.ResetColor();
            for (int i = 0; i < employees.Length; i++) 
            {
                int nexti = (i + 1) % employees.Length;
                employees[i].CompareSalary (employees[nexti]);
            }
            Console.WriteLine();
        }


    }
} 
