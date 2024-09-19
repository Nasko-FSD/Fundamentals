string inputText = Console.ReadLine().ToLower();
string word = Console.ReadLine().ToLower();
var counter = 0;
var position = 0;
while (true)
{
    position = inputText.IndexOf(word, position); // Find me the word from position word to right
    if (position == -1)
    {
        break;
    }
    else
    {
        counter++;
        position = position + 1; // Search from position + 1 Cause we already find one
    }
}
Console.WriteLine(counter);