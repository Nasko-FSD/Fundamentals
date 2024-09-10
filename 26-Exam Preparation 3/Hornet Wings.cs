int flaps = int.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
int endurance =  int.Parse(Console.ReadLine()); 


double calcDistance = (flaps / 1000) * distance;


double flyLength = (flaps / 100) + (flaps / endurance) * 5;

Console.WriteLine($"{calcDistance:f2} m.");
Console.WriteLine($"{flyLength} s.");