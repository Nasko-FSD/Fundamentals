using System.Text.RegularExpressions;

string privateMessagePattern = @"^([0-9]+) <-> ([a-zA-Z0-9]+)$";
string broadcastPattern = @"^([^0-9\n]+) <-> ([a-zA-Z0-9]+)$";

List<string> privateMessages = new List<string>();
List<string> broadcastMessages = new List<string>();

string input = "";

while ((input = Console.ReadLine()) != "Hornet is Green")
{
    Match privateMatch = Regex.Match(input, privateMessagePattern);
    Match broadcastMatch = Regex.Match(input, broadcastPattern);

    if (privateMatch.Success)
    {
        string recipientCodeInput = string.Join("", privateMatch.Groups[1].Value.Reverse());
        string message = privateMatch.Groups[2].Value;
        privateMessages.Add(recipientCodeInput + " -> " + message);
    }

    if (broadcastMatch.Success)
    {
        string frequencyInput = broadcastMatch.Groups[2].Value;
        string frequency = "";

        for (int i = 0; i < frequencyInput.Length; i++)
        {
            if (char.IsUpper(frequencyInput[i]))
            {
                frequency += frequencyInput[i].ToString().ToLower();
            }
            else
            {
                frequency += frequencyInput[i].ToString().ToUpper();
            }
        }
        string message = broadcastMatch.Groups[1].Value;
        broadcastMessages.Add(frequency + " -> " + message);
    }
}
Console.WriteLine("Broadcasts:");
if (broadcastMessages.Count > 0)
{
    Console.WriteLine(string.Join("\n", broadcastMessages));
}
else
{
    Console.WriteLine("None");
}
Console.WriteLine("Messages:");
if (privateMessages.Count > 0)
{
    Console.WriteLine(string.Join("\n", privateMessages));
}
else
{
    Console.WriteLine("None");
}