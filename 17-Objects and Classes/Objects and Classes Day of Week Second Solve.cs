using System.Globalization;

string inputData = Console.ReadLine();
DateTime date = DateTime
    .ParseExact(inputData, "d-M-yyyy",
    CultureInfo.InvariantCulture);

Console.WriteLine(date.DayOfWeek);
