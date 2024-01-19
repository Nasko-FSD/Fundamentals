int number = int.Parse(Console.ReadLine());
int sum = 0;
int i = 1;
while (i < 11)
{
    sum = number * i;
    Console.WriteLine($"{number} X {i} = {sum}");
    i++;
}