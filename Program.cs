using System;

namespace task3
{
    class Converter
    {
        private double usdToUah;
        private double eurToUah;
        public Converter(double usd, double eur)
        {
            usdToUah = usd;
            eurToUah = eur;
        }
        
        public double UsdConvertToUah(double usd)
        {
            return usd * usdToUah;
        }
        public double UahConvertToUsd(double uah)
        {
            return uah / usdToUah;
        }
        public double EurConvertToUah(double eur)
        {
            return eur * eurToUah;
        }
        public double UahConvertToEur(double uah)
        {
            return uah / eurToUah;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Задайте курс долара :");
                double usd1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Задайте курс євро :");
                double eur1 = Convert.ToDouble(Console.ReadLine());
                Converter c = new Converter(usd1, eur1);
                Console.WriteLine("Виберiть операцiю :\n 1 - UsdConvertToUah\n 2 - UahConvertToUsd\n 3 - EurConvertToUah\n 4 - UahConvertToEur ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Введiть суму у доларах");
                        double sum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} грн", c.UsdConvertToUah(sum1));
                        break;
                    case "2":
                        Console.WriteLine("Введiть суму у гривнях");
                        double sum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} usd", c.UahConvertToUsd(sum2));
                        break;
                    case "3":
                        Console.WriteLine("Введiть суму у євро");
                        double sum3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} грн", c.EurConvertToUah(sum3));
                        break;
                    case "4":
                        Console.WriteLine("Введiть суму у гривнях");
                        double sum4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} eur", c.UahConvertToEur(sum4));
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }

        }
    }
}
