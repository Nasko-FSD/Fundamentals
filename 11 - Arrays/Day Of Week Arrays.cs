string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int n = int.Parse(Console.ReadLine()); 
if (n < 1 || n > 7)          
{
    Console.WriteLine("Invalid day!");
}
else
{
    var weekDay = days[n - 1];         
    Console.WriteLine(weekDay);
}