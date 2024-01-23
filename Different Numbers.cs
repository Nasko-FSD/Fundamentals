int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

if (secondNumber - firstNumber < 5)
{
    Console.WriteLine("No");
}
else
{
    for (int d1 = firstNumber; d1 <= secondNumber; d1++)
    {
        for (int d2 = firstNumber; d2 <= secondNumber; d2++)
        {
            for (int d3 = firstNumber; d3 <= secondNumber; d3++)
            {
                for (int d4 = firstNumber; d4 <= secondNumber; d4++)
                {
                    for (int d5 = firstNumber; d5 <= secondNumber; d5++)
                    {
                        bool isValid = firstNumber <= d1 &&
                            d1 < d2 &&
                            d2 < d3 &&
                            d3 < d4 &&
                            d4 < d5 &&
                            d5 <= secondNumber;
                        if (isValid)
                        {
                            Console.WriteLine($"{d1} {d2} {d3} {d4} {d5}");
                        }
                    }
                }
            }
        }
    }
}