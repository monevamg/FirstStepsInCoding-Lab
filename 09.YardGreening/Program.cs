using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double squareMeters = double.Parse(Console.ReadLine());

          
            double price = squareMeters * 7.61;
            double discount = price*0.18;
           
            double finalAmount = price-discount;

            Console.WriteLine($"The final price is: {finalAmount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");




        }
    }
}
