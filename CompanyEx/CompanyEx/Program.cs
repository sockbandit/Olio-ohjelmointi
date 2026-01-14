namespace CompanyEx.CompanyEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company firma1 = new Company("Epic Games", "Kauppakatu 70", "0401234567", 200000, 150000);
            Company firma2 = new Company("Riot Games", "Valtakatu 40", "0409876543", 350000, 75000);
            /*firma1.PrintCompanyInfo();
            firma2.PrintCompanyInfo();
            */
            
            
            
            Console.WriteLine(firma1.ToString());
            firma1.PrintFinancialStatus();
            Console.WriteLine();
            Console.WriteLine(firma2.ToString());
            firma2.PrintFinancialStatus();
            Console.WriteLine();
            Console.WriteLine("Firma uusiks");
            Company firma3 = new Company(firma1);
            Console.WriteLine(firma3.ToString());
        }
    }
}
