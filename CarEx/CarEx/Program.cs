namespace CarEx.CarEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            car1.AskData();             //Pyydetään käyttäjältä tiedot kummallekin autolle :)   
            car2.AskData(); 
            car1.ShowCarinfo();
            car2.ShowCarinfo();
            car1.Accelerate(100);       //Molemmat autot kiihdyttävät 100 km/h
            car1.ShowCarinfo();
            car2.Accelerate(100);
            car2.ShowCarinfo();
            car1.Brake();               //Molemmat autot jarruttavat 10%   
            car1.ShowCarinfo();
            car2.Brake();
            car2.ShowCarinfo();
        }
    }
}
