﻿string word = Console.ReadLine();
if (word.EndsWith('y'))
{
    word = word.Remove(word.Length - 1, 1) + "ies";
}
else if (word.EndsWith('o') || word.EndsWith("ch") || word.EndsWith('s') || word.EndsWith("sh") || word.EndsWith('x') || word.EndsWith('z'))
{
    word = word + "es";
}
else
{
    word = word + "s";
}
Console.WriteLine(word);