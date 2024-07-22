using System.Text.RegularExpressions;
class Weather
{
    static void Main()
    {
        Dictionary<string, Forecast> weatherForecast = new Dictionary<string, Forecast>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end")
            {
                break;
            }
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+(?=\|))";
            MatchCollection validInput = Regex.Matches(inputLine, pattern);
            foreach (Match match in validInput)
            {
                string city = match.Groups[1].Value;
                decimal temperature = decimal.Parse(match.Groups[2].Value);
                string weather = match.Groups[3].Value;
                if (weatherForecast.ContainsKey(city) == false)
                {
                    weatherForecast.Add(city, new Forecast(temperature, weather));
                }
                else
                {
                    weatherForecast[city].Temperature = temperature;
                    weatherForecast[city].Weather = weather;
                }
            }
        }
        foreach (var city in weatherForecast.OrderBy(c => c.Value.Temperature))
        {
            Console.WriteLine($"{city.Key} => {city.Value.Temperature:f2} => {city.Value.Weather}");
        }
    }
    class Forecast
    {
        public Forecast(decimal temperature, string weather)
        {
            Temperature = temperature;
            Weather = weather;
        }
        public decimal Temperature { get; set; }
        public string Weather { get; set; }
    }
}