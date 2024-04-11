Dictionary<string, long> totalPopulation = new Dictionary<string, long>();//Country with it's total population
Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();//coutry, cities, population

while (true)
{
    string[] inputData = Console.ReadLine()
        .Split('|')
        .ToArray();

    if (inputData[0] == "report")
    {
        break;
    }

    string city = inputData[0];
    string country = inputData[1];
    long population = long.Parse(inputData[2]);

    if (totalPopulation.ContainsKey(country) == false)
    {
        totalPopulation.Add(country, 0);
        countriesAndCities.Add(country, new Dictionary<string, long>());
    }
    totalPopulation[country] += population;

    countriesAndCities[country].Add(city, population);
}

foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
{
    Console.WriteLine($"{country.Key} (total population: {country.Value})");
    Dictionary<string, long> cities = countriesAndCities[country.Key]
        .OrderByDescending(c => c.Value)
        .ToDictionary(x => x.Key, x => x.Value);

    foreach (var city in cities)
    {
        Console.WriteLine($"=>{city.Key}: {city.Value}");
    }
}