string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
Random message = new Random();
int counter = int.Parse(Console.ReadLine());

for (int i = 0; i < counter; i++)
{
    int phraseIndex = message.Next(0, Phrases.Length);
    int eventIndex = message.Next(0, Events.Length);
    int authorIndex = message.Next(0, Authors.Length);
    int townIndex = message.Next(0, Cities.Length);

    string result = $"{Phrases[phraseIndex]} {Events[eventIndex]} {Authors[authorIndex]} - {Cities[townIndex]}";
    Console.WriteLine(result);
}