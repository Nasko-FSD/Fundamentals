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
        SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
        for(int i = 0; i < items.Length; i++)
        {
            if (!salesByTown.ContainsKey(items[i].Town))
            {
                salesByTown.Add(items[i].Town, 0);
            }
            salesByTown[items[i].Town] += items[i].Price * items[i].Quantity;
        }
        foreach(var Town in salesByTown)
        {
            Console.WriteLine($"{Town.Key} -> {Town.Value:f2}");
        }
    }

    static Sale[] ReadSale()
    {
        var n = int.Parse(Console.ReadLine());
        var sales = new Sale[n];
        for(int i = 0; i < n; i++)
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
