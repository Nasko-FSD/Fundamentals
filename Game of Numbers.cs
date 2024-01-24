int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int magicalNumber = int.Parse(Console.ReadLine());
int counter = 0;
int totalSum = 0;
for (int i = secondNumber; i >= firstNumber; i--)
{
    for (int j = secondNumber; j >= firstNumber; j--)
    {
        totalSum = (i + j);
        counter++;
        if (totalSum == magicalNumber)
        {
            Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
            return;
        }
    }
}
Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");