var dateElements = Console.ReadLine()
    .Split('-')
    .Select(int.Parse)
    .ToArray();
var date = new DateTime(dateElements[2], dateElements[1], dateElements[0]);
Console.WriteLine(date.DayOfWeek);