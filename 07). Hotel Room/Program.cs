using System;

namespace _07_._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
           
            double studio = 0.0;
            double apartament = 0.0;
            if (month == "May" || month == "October")
            {
                studio = 50;
                apartament = 65;
                if (days > 7 && days <= 14)
                {
                    studio *= 0.95;
                }
                else if (days > 14)
                {
                    studio *= 0.7;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.2;
                apartament = 68.7;
                if (days > 14)
                {
                    studio *= 0.8;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartament = 77;
            }
            if (days > 14)
            {
                apartament *= 0.9;
            }
            Console.WriteLine($"Apartment: {days * apartament:F2} lv.");
            Console.WriteLine($"Studio: {days * studio:F2} lv.");

           
        }
    }
}
