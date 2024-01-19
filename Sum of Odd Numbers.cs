int counter = int.Parse(Console.ReadLine());
int sum = 0;
int currentNumber = 1;
int i = 0;
while (i < counter)
{
    Console.WriteLine(currentNumber);
    sum += currentNumber;
    currentNumber += 2;
    i++;
}
Console.WriteLine($"Sum: {sum}");