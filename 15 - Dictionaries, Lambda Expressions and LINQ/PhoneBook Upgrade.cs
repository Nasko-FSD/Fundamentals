SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

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

        string contactName = inputString[1];
        if (phoneBook.ContainsKey(contactName))
        {
            string foundNumber = phoneBook[contactName];
            Console.WriteLine($"{contactName} -> {foundNumber}");
        }
        else
        {
            Console.WriteLine($"Contact {contactName} does not exist.");
        }
    }

    if (command == "ListAll")
    {
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Key} -> {contact.Value}");
        }
    }
}