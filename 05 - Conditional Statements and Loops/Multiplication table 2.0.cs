﻿int input = int.Parse(Console.ReadLine());
for (int i = 1; i <= input; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}