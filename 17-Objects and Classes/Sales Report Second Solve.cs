class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}
class Program
{
    static void Main()
    {
        Sale[] items = ReadSale();
        var towns = items.Select(s => s.Town).Distinct().OrderBy(t => t);
        foreach (var town in towns)
        {
            var salesByTown = items.Where(s => s.Town == town)
              .Select(s => s.Price * s.Quantity).Sum();
            Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
        }

    }

    static Sale[] ReadSale()
    {
        var n = int.Parse(Console.ReadLine());
        var sales = new Sale[n];
        for (int i = 0; i < n; i++)
        {
            sales[i] = ReadSalesSeparate();
        }
        return sales;
    }

    static Sale ReadSalesSeparate()
    {
        var items = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Sale values = new Sale() { Town = items[0], Product = items[1], Price = decimal.Parse(items[2]), Quantity = decimal.Parse(items[3]) };
        return values;
    }
}
