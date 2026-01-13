using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEx.CarEx
{
    internal class Car
    {
        public String brand; //moi
        public double speed;

        public Car()
        {
            this.brand = String.Empty;
            this.speed = 0;
        }

        public Car(string brand, double speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public void AskData()
        {
            Console.WriteLine("Give a car brand"); //Pyydetään käyttäjältä autojen tiedot 
            this.brand = Console.ReadLine();
            Console.WriteLine("Give a car speed");
            double.TryParse(Console.ReadLine(), out this.speed);
        }
        public void ShowCarinfo()
        {
            Console.WriteLine($"{this.brand}, Speed: {this.speed} km/h"); //Näytetään auton tiedot

        }
        public void Accelerate(double value)
        {
            if (value > 0)
            {
                this.speed += value;
            }
        }
        public void Brake()
        {
            this.speed *= 0.9;
        }
    }
}
