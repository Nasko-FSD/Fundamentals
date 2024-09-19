decimal usPrice = decimal.Parse(Console.ReadLine());
long usWeight = long.Parse(Console.ReadLine());

decimal ukPrice = decimal.Parse(Console.ReadLine());
long ukWeight = long.Parse(Console.ReadLine());

decimal chinaPrice = decimal.Parse(Console.ReadLine());
long chinaWeight = long.Parse(Console.ReadLine());

usPrice /= 0.58M;
ukPrice /= 0.41M;
chinaPrice *= 0.27M;

decimal usPerKilo = usPrice / usWeight;
decimal ukPerKilo = ukPrice / ukWeight;
decimal chinaPerKilo = chinaPrice / chinaWeight;

decimal minPricePerKilo = Math.Min(Math.Min(usPerKilo, ukPerKilo), chinaPerKilo);
decimal maxPricePerKilo = Math.Max(Math.Max(usPerKilo, ukPerKilo), chinaPerKilo);

if (minPricePerKilo == usPerKilo)
{
    Console.WriteLine($"US store. {minPricePerKilo:f2} lv/kg");
}
else if (minPricePerKilo == ukPerKilo)
{
    Console.WriteLine($"UK store. {minPricePerKilo:f2} lv/kg");
}
else
{
    Console.WriteLine($"Chinese store. {minPricePerKilo:f2} lv/kg");
}
Console.WriteLine($"Difference {maxPricePerKilo - minPricePerKilo:f2} lv/kg");