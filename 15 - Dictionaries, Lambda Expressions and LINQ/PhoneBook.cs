Dictionary<string, string> phoneBook = new Dictionary<string, string>();

while (true)
{
    string[] inputString = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    string command = inputString[0];

    if (command == "END")
    {
        break;
    }

    if (command == "A")
    {
        string contactName = inputString[1];
        string contactPhone = inputString[2];

        if (!phoneBook.ContainsKey(contactName))
        {
            phoneBook.Add(contactName, contactPhone);
        }
        else if (phoneBook.ContainsKey(contactName))
        {
            phoneBook[contactName] = contactPhone;
        }
    }

    if (command == "S")
    {
        string searchName = inputString[1];

        if (!phoneBook.ContainsKey(searchName))
        {
            Console.WriteLine($"Contact {searchName} does not exist.");
        }
        else if (phoneBook.ContainsKey(searchName))
        {
            string foundNumber = phoneBook[searchName];
            Console.WriteLine($"{searchName} -> {foundNumber}");
        }
    }
}