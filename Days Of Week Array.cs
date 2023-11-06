string[] days = new string[7]; 
days[0] = "Monday"; 
days[1] = "Tuesday";
days[2] = "Wednesday";
days[3] = "Thursday";
days[4] = "Friday";
days[5] = "Saturday";
days[days.Length - 1] = "Sunday";
for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);
}