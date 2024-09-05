List<string> words = Console.ReadLine()
    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input = "";

while ((input = Console.ReadLine()) != "3:1")
{
    string[] tokens = input
        .Split(" ".ToCharArray())
        .ToArray();

    string command = tokens[0];

    if (command == "merge")
    {
        int startIndex = int.Parse(tokens[1]);
        int endIndex = int.Parse(tokens[2]);

        if (endIndex < 0 || startIndex > words.Count - 1)
        {
            continue;
        }

        if (endIndex > words.Count - 1)
        {
            endIndex = words.Count - 1;
        }

        if (startIndex < 0)
        {
            startIndex = 0;
        }

        string concatWords = "";

        for (int i = startIndex; i <= endIndex; i++)
        {
            concatWords += words[i];
        }

        words.RemoveRange(startIndex, endIndex - startIndex + 1);
        words.Insert(startIndex, concatWords);
    }

    if (command == "divide")
    {
        int index = int.Parse(tokens[1]);
        int partitions = int.Parse(tokens[2]);

        string element = words[index];

        int partLength = element.Length / partitions;

        List<string> newWords = new List<string>();

        for (int i = 0; i < partitions; i++) // On how many parts we have to divide the element(part from the words)
        {
            if (partitions - i == 1) // The last part from the element
            {
                newWords.Add(element.Substring(i * partLength));//From i * partLength to the end of the element.Length
                break;
            }
            newWords.Add(element.Substring(i * partLength, partLength));//From i * partLength == startIndex take partLength
                                                                                                 // as value for length
        }
        words.RemoveAt(index);
        words.InsertRange(index, newWords);
    }
}
Console.WriteLine(string.Join(" ", words));