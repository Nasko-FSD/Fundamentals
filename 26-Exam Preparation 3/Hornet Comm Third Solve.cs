using System.Text.RegularExpressions;

string privateMessagePattern = @"^([0-9]+) <-> ([a-zA-Z0-9]+)$";
string broadcastPattern = @"^([^0-9\n]+) <-> ([a-zA-Z0-9]+)$";

List<string> privateMessages = new List<string>();
List<string> broadCastMessages = new List<string>();

string input = "";

while ((input = Console.ReadLine()) != "Hornet is Green")
{
    Match privateMatch = Regex.Match(input, privateMessagePattern);
    Match broadcastMatch = Regex.Match(input, broadcastPattern);

    if (privateMatch.Success)
    {
        string recipientCodeInput = new string(privateMatch.Groups[1].Value.ToCharArray().Reverse().ToArray());
        string message = privateMatch.Groups[2].Value;
        privateMessages.Add(recipientCodeInput + " -> " + message);
    }

    if (broadcastMatch.Success)
    {
        string frequencyInput = broadcastMatch.Groups[2].Value;
        string frequency = "";
        foreach (var letter in frequencyInput)
        {
            if (char.IsUpper(letter))
            {
                frequency += char.ToLower(letter);
            }
            else
            {
                frequency += char.ToUpper(letter);
            }
        }
        string message = broadcastMatch.Groups[1].Value;
        broadCastMessages.Add(frequency + " -> " + message);
    }
}

Console.WriteLine("Broadcasts:");
if (broadCastMessages.Count > 0)
{
    foreach (var message in broadCastMessages)
    {
        Console.WriteLine(message);
    }
}
else
{
    Console.WriteLine("None");
}
Console.WriteLine("Messages:");
if (privateMessages.Count > 0)
{

    foreach (var message in privateMessages)
    {
        Console.WriteLine(message);
    }
}
else
{
    Console.WriteLine("None");
}