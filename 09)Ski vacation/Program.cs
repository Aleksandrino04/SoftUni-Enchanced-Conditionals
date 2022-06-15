using System;

namespace _09_Ski_vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string mark = Console.ReadLine();

            double priceRoomOnePerson = 18;
            double priceRoomForApartment = 25;
            double priceRoomForPresident = 35;
            double discount = 0;

            double pricePerRoom = 0;
            if (room == "apartment")
            {
                pricePerRoom = priceRoomForApartment;
                if (days < 10)
                {
                    discount = 0.3;

                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;

                }
                else
                {
                    discount = 0.5;
                }

            }
            else if (room == "president apartment")
            {
                pricePerRoom = priceRoomForPresident;
                if (days < 10)
                {
                    discount = 0.1;

                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;

                }
                else
                {
                    discount = 0.2;
                }

            }
            else if (room == "room for one person")
            {
                pricePerRoom = priceRoomOnePerson;
            }
            double totalPrice = (days - 1) * pricePerRoom;
            double totalDiscountedPrice = totalPrice - totalPrice * discount;
           
            if (mark == "positive")
            {
                totalDiscountedPrice = totalDiscountedPrice + totalDiscountedPrice * 0.25;

            }
            else
            {
                totalDiscountedPrice = totalDiscountedPrice - totalDiscountedPrice * 0.10;
            }
            Console.WriteLine($"{totalDiscountedPrice:f2}");
        }   
        
        
    }
}
