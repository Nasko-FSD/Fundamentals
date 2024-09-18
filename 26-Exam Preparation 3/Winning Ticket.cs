using System.Text.RegularExpressions;

string[] tickets = Console.ReadLine()
    .Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);

foreach (var ticket in  tickets)
{
    if (ticket.Length == 20)
    {
        string leftHalf = ticket.Substring(0, 10);
        string rightHalf = ticket.Substring(10);

        string jackpotPattern = @"(\${20,20}|@{20,20}|#{20,20}|\^{20,20})";
        string matchPattern = @"(\${6,}|@{6,}|#{6,}|\^{6,})";
        if (Regex.IsMatch(ticket, jackpotPattern))
        {
            int length = Regex.Match(ticket, jackpotPattern).Groups[1].Length / 2;
           
            Console.WriteLine($"ticket \"{ticket}\" - {length}{ticket[0]} Jackpot!");
        }
        else if (Regex.IsMatch(leftHalf, matchPattern) && Regex.IsMatch(rightHalf, matchPattern) &&
            Regex.Match(leftHalf, matchPattern).Groups[1].Value[0] ==
            Regex.Match(rightHalf, matchPattern).Groups[1].Value[0])
        {
            char printChar = Regex.Match(leftHalf, matchPattern).Groups[1].Value[0];
            int leftLength = Regex.Match(leftHalf, matchPattern).Groups[1].Value.Length;
            int rightLength = Regex.Match(rightHalf, matchPattern).Groups[1].Value.Length;
            int length = Math.Min(leftLength, rightLength);
            
            Console.WriteLine($"ticket \"{ticket}\" - {length}{printChar}");
        }
        else
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
        }
    }
    else
    {
        Console.WriteLine("invalid ticket");
    }
}