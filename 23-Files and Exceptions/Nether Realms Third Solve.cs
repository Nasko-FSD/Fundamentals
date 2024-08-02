using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        string patternHealth = @"(?<health>[^0-9+\-*\/\.])+?";
        string patternDamage = @"(?<damage>-?\d+(\.\d+)?)";
        string patternModifiers = @"[\*\/]";

        Dictionary<string, (int Health, double Damage)> demons = new Dictionary<string, (int, double)>();

        foreach (string demon in inputLine)
        {
            int health = 0;
            foreach (Match letter in Regex.Matches(demon, patternHealth))
            {
                health += letter.Value[0];
            }

            double damage = 0.0;
            foreach (Match match in Regex.Matches(demon, patternDamage))
            {
                damage += double.Parse(match.Groups["damage"].Value);
            }

            foreach (Match match in Regex.Matches(demon, patternModifiers))
            {
                if (match.Value == "*")
                {
                    damage *= 2;
                }
                else if (match.Value == "/")
                {
                    damage /= 2;
                }
            }

            demons[demon] = (health, damage);
        }

        foreach (var demon in demons.OrderBy(d => d.Key))
        {
            Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
        }
    }
}