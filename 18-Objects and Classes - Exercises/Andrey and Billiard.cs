class Program
{
    static void Main()
    {
        List<Products> products = ReadProducts();
        List<Clients> clients = ReadClients(products);
        BillCalculation(clients, products);
    }

    class Products
    {
        public Products(string product, decimal price)
        {
            this.Name = product;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Clients
    {
        public Clients(string name)
        {
            this.Name = name;
            this.OrderedProducts = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> OrderedProducts { get; set; }
    }
    static void BillCalculation(List<Clients> clients, List<Products> products)
    {
        decimal totalBill = 0;
        foreach (Clients client in clients.OrderBy(c => c.Name))
        {
            Console.WriteLine(client.Name);
            decimal bill = 0;
            foreach (var orderedProduct in client.OrderedProducts)
            {
                Console.WriteLine($"-- {orderedProduct.Key} - {orderedProduct.Value}");
                string productName = orderedProduct.Key;
                int quantity = orderedProduct.Value;

                decimal price = products.First(p => p.Name == productName).Price;

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
                .Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string clientName = inputData[0];
            string productName = inputData[1];
            int productQuantity = int.Parse(inputData[2]);

            if (products.Any(p => p.Name == productName) == false)
            {
                continue;
            }

            Clients client = clients
                .FirstOrDefault(c => c.Name == clientName);

            if (client == null)
            {
                Clients newClient = new Clients(clientName);
                newClient.OrderedProducts.Add(productName, productQuantity);
                clients.Add(newClient);
            }
            else
            {
                if (client.OrderedProducts.ContainsKey(productName) == false)
                {
                    client.OrderedProducts.Add(productName, productQuantity);
                }
                else
                {
                    client.OrderedProducts[productName] += productQuantity;
                }
            }

        }
        return clients;
    }

    static List<Products> ReadProducts()
    {
        int number = int.Parse(Console.ReadLine());
        List<Products> products = new List<Products>();

        for (int i = 0; i < number; i++)
        {
            string[] inputData = Console.ReadLine()
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string productName = inputData[0];
            decimal price = decimal.Parse(inputData[1]);
            Products product = products.FirstOrDefault(p => p.Name == productName);
            if (product == null)
            {
                Products newProduct = new Products(productName, price);
                products.Add(newProduct);
            }
            else
            {
                product.Price = price;
            }
        }
        return products;
    }
}