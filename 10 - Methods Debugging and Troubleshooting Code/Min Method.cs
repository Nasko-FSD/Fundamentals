GetMin();

static void GetMin()
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int GetMin = Math.Min(Math.Min(num1, num2), num3);
    Console.WriteLine(GetMin);
}