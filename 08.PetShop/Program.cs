using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPackDogFood = int.Parse(Console.ReadLine());
            int numberPackCatFood = int.Parse(Console.ReadLine());

            double pricePackDogFood = numberPackDogFood * 2.50;
            double pricePackCatFood = numberPackCatFood * 4.0;
            double finalAmount = pricePackDogFood + pricePackCatFood;

            Console.WriteLine($"{finalAmount} lv.");





        }
    }
}
