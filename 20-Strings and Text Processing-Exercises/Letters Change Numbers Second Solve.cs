
decimal sum = 0;
while (true)
{
    string inputLine = Console.ReadLine();
    if (inputLine == "End")
    {
        break;
    }
    string[] inputText = inputLine
    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    foreach (var arr in inputText)
    {
        string words = arr.ToLower();
        char[] alphabet = new char[27];
        int index = 1;
        for (char i = 'a'; i <= 'z'; i++)
        {
            alphabet[index++] = i;
        }
        int position = 0;
        char currentChar = ' ';
        decimal number = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (char.IsLetter(arr[i]))
            {
                currentChar = arr[i];
                position = Array.IndexOf(alphabet, words[i]);
            }
            else
            {
                continue;
            }
            string numbersString = arr.Substring(1, arr.Length - 2);
            number = int.Parse(numbersString);
            if (i < arr.Length / 2)
            {
                if (char.IsUpper(currentChar))
                {
                    sum += number / position;
                }
                else if (char.IsLower(currentChar))
                {
                    sum += number * position;
                }
            }
            else
            {
                if (char.IsUpper(currentChar))
                {
                    sum -= position;
                }
                else if (char.IsLower(currentChar))
                {
                    sum += position;
                }
            }
        }
    }
}
Console.WriteLine($"{sum:f2}");