PrintNthDigit();
static void PrintNthDigit()
{
    int num = int.Parse(Console.ReadLine());
    int index = int.Parse(Console.ReadLine());
    int count = 1;
        while (num >= 0)
        {
            if (count == index)
            {
                num %= 10;
            Console.WriteLine(num); break;
            }
            num = num / 10;
            count++;
        }
}