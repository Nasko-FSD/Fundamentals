Dictionary<string, Dictionary<string, long>> countriesPopulation = new Dictionary<string, Dictionary<string, long>>();

while (true)
{
    string[] inputData = Console.ReadLine()
        .Split("|");

    if (inputData[0] == "report")
    {
        break;
    }

    string country = inputData[1];
    string cities = inputData[0];
    long population = long.Parse(inputData[2]);

    if (countriesPopulation.ContainsKey(country) == false)
    {
        countriesPopulation.Add(country, new Dictionary<string, long>());
    }
    if (countriesPopulation[country].ContainsKey(cities) == false)
    {
        countriesPopulation[country].Add(cities, population);
    }
}
var sortedCountries = countriesPopulation.OrderByDescending(c => c.Value.Sum(city => city.Value));
foreach (var country in sortedCountries)
{
    Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(city => city.Value)})");
    var sortedCities = country.Value.OrderByDescending(city => city.Value);
    foreach (var city in sortedCities)
    {
        Console.WriteLine($"=>{city.Key}: {city.Value}");
    }
}