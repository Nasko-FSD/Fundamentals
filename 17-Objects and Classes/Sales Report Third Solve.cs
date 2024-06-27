using System;
using System.Collections.Generic;
using System.Linq;
class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }

    static void Main(string[] args)
    {
        Sale[] sales = ReadSales();
        PrintResult(sales);
    }
    static Sale[] ReadSales()
    {
        SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
        int quantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantity; i++)
        {
            string[] inputData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string town = inputData[0];
            decimal sales = decimal.Parse(inputData[2]) * decimal.Parse(inputData[3]);

            if (salesByTown.ContainsKey(town) == false)
            {
                salesByTown.Add(town, 0);
            }
            salesByTown[town] += sales;
        }
        Sale[] result = new Sale[salesByTown.Count];
        int index = 0;

        foreach (var town in salesByTown)
        {
            result[index] = new Sale { Town = town.Key, Price = town.Value };
            index++;
        }
        return result;
    }
    static void PrintResult(Sale[] sales)
    {
        foreach (var sale in sales)
        {
            Console.WriteLine($"{sale.Town} -> {sale.Price:f2}");
        }
    }
}