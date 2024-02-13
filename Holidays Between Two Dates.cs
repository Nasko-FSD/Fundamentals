using System.Globalization;
Console.WriteLine("Enter first date in format type: d.M.yyy");
var startDate = DateTime.ParseExact(Console.ReadLine(),
  "d.M.yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Enter second date in format type: d.M.yyy");

var endDate = DateTime.ParseExact(Console.ReadLine(),
  "d.M.yyyy", CultureInfo.InvariantCulture);

var holidaysCount = 0;

for (var date = startDate; date <= endDate; date = date.AddDays(1))
{
    if (date.DayOfWeek == DayOfWeek.Saturday ||
        date.DayOfWeek == DayOfWeek.Sunday)
    {
        holidaysCount++;
    }
}

Console.WriteLine(holidaysCount);