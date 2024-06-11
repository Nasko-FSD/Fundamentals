
class Program
{
    class Products
    {
        public Products(string productName, decimal productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
    class Clients
    {
        public Clients(string clientName, Dictionary<string, int> OrderedProducts)
        {
            ClientName = clientName;
            this.OrderedProducts = OrderedProducts;
        }

        public string ClientName { get; set; }
        public Dictionary<string, int> OrderedProducts { get; set; }
    }
    static void Main()
    {
        List<Products> products = ReadProducts();
        List<Clients> clientsList = ReadClients(products);
        BillCalculations(clientsList, products);
    }

    static void BillCalculations(List<Clients> clientsList, List<Products> products)
    {
        decimal totalBill = 0;
        foreach (Clients client in clientsList.OrderBy(c => c.ClientName))
        {
            Console.WriteLine(client.ClientName);
            decimal bill = 0;
            foreach (var orderedProduct in client.OrderedProducts)
            {
                Console.WriteLine($"-- {orderedProduct.Key} - {orderedProduct.Value}");
                string productName = orderedProduct.Key;
                int quantity = orderedProduct.Value;
                decimal price = products.First(p => p.ProductName == productName).ProductPrice;
                bill += quantity * price;
            }
            totalBill += bill;
            Console.WriteLine($"Bill: {bill:f2}");
        }
        Console.WriteLine($"Total bill: {totalBill:f2}");
    }

    static List<Clients> ReadClients(List<Products> products)
    {
        List<Clients> clients = new List<Clients>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of clients")
            {
                break;
            }
            string[] inputData = inputLine
                .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string clientName = inputData[0];
            string productName = inputData[1];
            int quantity = int.Parse(inputData[2]);
            if (products.Any(p => p.ProductName == productName) == false)
            {
                continue;
            }
            Clients client = clients
                .FirstOrDefault(c => c.ClientName == clientName);
            if (client == null)
            {
                Clients newClient = new Clients(clientName, new Dictionary<string, int> { { productName, quantity } });
                clients.Add(newClient);
            }
            else
            {
                if (client.OrderedProducts.ContainsKey(productName) == false)
                {
                    client.OrderedProducts.Add(productName, quantity);
                }
                else
                {
                    client.OrderedProducts[productName] += quantity;
                }
            }
        }
        return clients;
    }

    static List<Products> ReadProducts()
    {
        List<Products> products = new List<Products>();
        int amount = int.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++)
        {
            string[] inputData = Console.ReadLine()
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string productName = inputData[0];
            decimal productPrice = decimal.Parse(inputData[1]);
            Products product = products
                .FirstOrDefault(p => p.ProductName == productName);
            if (product == null)
            {
                Products newProduct = new Products(productName, productPrice);
                products.Add(newProduct);
            }
            else
            {
                product.ProductPrice = productPrice;
            }
        }
        return products;
    }
}