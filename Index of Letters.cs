string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    int value = input[i] - 97;
    Console.WriteLine($"{input[i]} -> {value}");
}