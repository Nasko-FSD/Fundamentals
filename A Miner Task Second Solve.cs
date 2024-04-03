Dictionary<string, int> wareHouse = new Dictionary<string, int>();

while (true)
{
    string resource = Console.ReadLine();
    if (resource == "stop")
    {
        break;
    }
    int quantity = int.Parse(Console.ReadLine());

    if (!wareHouse.ContainsKey(resource))
    {
        wareHouse.Add(resource, 0);
    }
    wareHouse[resource] += quantity;
}

foreach (var product in wareHouse)
{
    Console.WriteLine($"{product.Key} -> {product.Value}");
}