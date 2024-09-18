double sideSize = double.Parse(Console.ReadLine());
string parameters = Console.ReadLine();

PrintResult(sideSize, parameters);

static void PrintResult(double sideSize, string parameters)
{
    double result = Calculate(sideSize, parameters);
    Console.WriteLine($"{result:f2}");
}

static double Calculate(double sideSize, string parameters)
{
    double result = 0;
    if (parameters == "face")
    {
        result = Math.Sqrt(2 * Math.Pow(sideSize, 2));
    }
    else if (parameters == "volume")
    {
        result = Math.Pow(sideSize, 3);
    }
    else if (parameters == "space")
    {
        result = Math.Sqrt(3 * Math.Pow(sideSize, 2));
    }
    else
    {
        result = 6 * Math.Pow(sideSize, 2);
    }
    return result;
}