﻿using System.Text.RegularExpressions;

string keyWord = Console.ReadLine();
string[] sentences = Console.ReadLine().Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
string pattern = @"\W"; // All non-letter chars
List<string> results = new List<string>();

foreach (string sentence in sentences)
{
    string[] words = Regex.Split(sentence, pattern);
    if (words.Any(w => w.Equals(keyWord)))
    {
        results.Add(sentence);
    }
}

foreach (string keySentence in results)
{
    Console.WriteLine(keySentence.Trim());
}