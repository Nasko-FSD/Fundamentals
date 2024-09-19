using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters_Second_Solve
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = (char)(int.Parse(Console.ReadLine())) + 'a';
            for (char i = 'a'; i < input; i++)
            {
                for (char j = 'a'; j < input; j++)
                {
                    for (char k = 'a'; k < input; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
