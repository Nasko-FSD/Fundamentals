Dictionary<string, int> wareHouse = new Dictionary<string, int>();

while (true)
{
    string inputData = "";
    int inputQuantity;

    for (int i = 0; ; i++)
    {
        if (i % 2 == 0)
        {
            inputData = Console.ReadLine();

            if (inputData == "stop")
            {
                break;
            }
            if (!wareHouse.ContainsKey(inputData))
            {
                wareHouse.Add(inputData, 0);
            }
        }
        else if (i % 2 == 1)
        {
            inputQuantity = int.Parse(Console.ReadLine());
            int defaultValue = 0;
            if (wareHouse.ContainsValue(defaultValue))
            {
                wareHouse[inputData] = inputQuantity;
            }
            else if (!wareHouse.ContainsValue(defaultValue))
            {
                wareHouse[inputData] += inputQuantity;
            }
        }
    }

    foreach (var product in wareHouse)
    {
        Console.WriteLine($"{product.Key} -> {product.Value}");
    }
    if (inputData == "stop")
    {
        break;
    }
}