using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            int count = 0;
            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    Console.Write(currentNum + " ");
                    count++;
                }
                else if (currentNum < 0 && j != numbers.Count - 1)
                {
                    currentNum += numbers[j + 1];

                    if (currentNum >= 0)
                    {
                        Console.Write(currentNum + " ");
                        count++;
                    }
                    j++;
                }
            }
            if (count <= 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}