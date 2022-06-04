using System;
using System.Collections.Generic;
using System.Linq;

public class ProductShop
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

        string input = Console.ReadLine();

        while(true)
        {
            string[] tokens = input.Split(", ");
            string shopName = tokens[0];
            string productName = tokens[1];
            double productPrice = double.Parse(tokens[2]);

            if(!shops.ContainsKey(shopName))
            {
                shops[shopName] = new Dictionary<string, double>();
            }

            shops[shopName][productName] = productPrice;

            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            input = Console.ReadLine();

            if (input == "Revision")
            {
                PrintShops(orderedShops);
                break;
            }
        }
    }

    static void PrintShops(Dictionary<string, Dictionary<string, double>> shops)
    {
        foreach(var (shop, product) in shops)
        {
            Console.WriteLine($"{shop}->");

            foreach(var (productName, price) in product)
            {
                Console.WriteLine($"Product: {productName}, Price: {price}");
            }
        }
    }
}
