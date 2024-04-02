Dictionary<string, string> listOfEmails = new Dictionary<string, string>();

string emailName = Console.ReadLine();
string[] specialCharacters = { "us", "uk" };

while (emailName != "stop")
{
    string theEmail = Console.ReadLine(); ;

    if (!listOfEmails.ContainsKey(emailName))
    {
        listOfEmails.Add(emailName, "");
    }

    bool containsSpecialCharacters = false;
    foreach (var specialChar in specialCharacters)
    {
        if (theEmail.EndsWith(specialChar))
        {
            containsSpecialCharacters = true;
            break;
        }
    }
    if (containsSpecialCharacters)
    {
        listOfEmails.Remove(emailName);
    }

    else if (listOfEmails.ContainsKey(emailName))
    {
        listOfEmails[emailName] = theEmail;
    }

    emailName = Console.ReadLine();
}

foreach (var email in listOfEmails)
{
    Console.WriteLine($"{email.Key} -> {email.Value}");
}