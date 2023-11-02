int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
for (int arrayLength = 0; arrayLength < numbers.Length; arrayLength++)
{
    numbers[arrayLength] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < numbers.Length / 2; i++)
{
    var oldElement = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = oldElement;
}
foreach (var elements in numbers)
{
    Console.WriteLine(elements);
}