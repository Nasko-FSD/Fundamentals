﻿using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine();

        while (opCode != "END")
        {
            string[] codeArgs = opCode
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            opCode = Console.ReadLine();
            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            Console.WriteLine(result);
        }
    }
}