class Sale
{
    public string Country { get; set; }
    public decimal Price { get; set; }
    public decimal Currency { get; set; }
    public decimal Weight { get; set; }
}
class Program
{
    static void Main()
    {
        Sale[] orderInformation = ReadSales();

        var countries = orderInformation.Select(x => x.Country).Distinct().OrderBy(c => c);
        foreach (var country in countries)
        {
            if (country != "china")
            {
                var salesByCountry = orderInformation.Where(x => x.Country == country)
                    .Select(x => x.Price /= x.Currency);
                Console.WriteLine("{0} store. -> {1}", country, salesByCountry.First().ToString("F2"));
            }
            else
            {
                var salesByCountry = orderInformation.Where(x => x.Country == country)
                    .Select(x => x.Price *= x.Currency);
                Console.WriteLine("{0} store. -> {1}", country, salesByCountry.First().ToString("F2"));
            }
        }
        Console.WriteLine();
        var prices = orderInformation.Select(x => x.Price).OrderBy(c => c);
        foreach (var price in prices)
        {
            var minPricePerKilo = orderInformation.Where(x => x.Price == price)
                .Select(x => x.Price /= x.Weight);
            Console.WriteLine("min price -> {0}", minPricePerKilo.First().ToString("F2"));
        }

        static Sale[] ReadSales()
        {
            Console.Write("Enter 3 times: Country, Price, Currency, Weight: ");
            var n = 3;
            var sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSalesSeparate();
            }
            return sales;
        }

        static Sale ReadSalesSeparate()
        {
            var orderDetails = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Sale splitDetails = new Sale() { Country = orderDetails[0], Price = decimal.Parse(orderDetails[1]), Currency = decimal.Parse(orderDetails[2]), Weight = decimal.Parse(orderDetails[3]) };
            return splitDetails;
        }
    }
}