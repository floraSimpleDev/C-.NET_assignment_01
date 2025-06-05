using System;

namespace CalculatePrice2
{
    public class CalculatePriceClass
    {
        public static void PriceCalculator()
        {
            int tshirt = 35;
            int trousers = 120;

            int tshirtQuantity = 3;
            int trousersQuantity = 2;

            int totalPrice = (tshirt * tshirtQuantity) + (trousers * trousersQuantity);

            Console.WriteLine($"The total price is: {totalPrice}");
        }
    }
}
