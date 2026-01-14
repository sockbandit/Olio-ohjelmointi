using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEx.CompanyEx
{
    internal class Company
    {
        public string title;
        public string address;
        public string phone;
        public double income;
        public double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.income = 0;
            this.expense = 0;
        }
        public Company(string title, string address, String phone,  double income, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expense = expense;
        }

        public Company(Company other)
        {
            this.title = other.title;
            this.address = other.address;
            this.phone = other.phone;
            this.income = other.income;
            this.expense = other.expense;
        }

        public void PrintCompanyInfo()
        {
            Console.WriteLine($"{title} : {address} : {phone} : {income} : {expense}");
        }

        public void PrintFinancialStatus()
        {
            if (this.income == 0)
            {
                Console.WriteLine("Voittoprosenttia ei voi laskea");  //Jos tulot ja menot on samat, ei lasketa prosenttia
                return;
            }

            double voitto = (income - expense) / income * 100;

            Console.WriteLine($"Voittoprosentti : {voitto:F2} %"); //Tulostetaan näytölle kahdella desimaalilla voittoprosentti

            if (voitto < 5)             //Lasketaan ja tulostetaan miten yrityksellä menee
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yrityksellä menee kehnosti");
            }

            else if (voitto < 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Yrityksellä menee välttävästi");
            }

            else if (voitto < 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yrityksellä menee tyydyttävästi");
            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yrityksellä menee hyvin");
            }
            Console.ResetColor();
        }

        public override string? ToString()
        {
            return $"{title} : {address} : {phone} : {income} : {expense}";
        }
    }
}
