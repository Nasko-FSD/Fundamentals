int peshoHealth = 100;
int goshoHealth = 100;
int roundCounter = 0;
int PeshosDamage = int.Parse(Console.ReadLine());
int GoshosDamage = int.Parse(Console.ReadLine());
bool gameWinner = false;
while (peshoHealth >= 0 || goshoHealth >= 0)
{
    for (int i = 1; i <= peshoHealth || goshoHealth <= 0; i++)
    {
        if (i % 2 == 0)
        {
            peshoHealth -= GoshosDamage;
            roundCounter++;
            if (peshoHealth <= 0)
            {
                gameWinner = true;
                break;
            }
            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
        }
        if (i % 2 == 1)
        {
            goshoHealth -= PeshosDamage;
            roundCounter++;
            if (goshoHealth <= 0)
            {
                gameWinner = true;
                break;
            }
            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
        }
        if (i % 3 == 0)
        {
            peshoHealth += 10;
            goshoHealth += 10;
        }
    }
    break;
}
if (gameWinner)
{
    if (goshoHealth > 0)
    {
        Console.WriteLine($"Gosho won in {roundCounter}th round.");
        return;
    }
    else if (peshoHealth > 0)
    {
        Console.WriteLine($"Pesho won in {roundCounter}th round.");
        return;
    }
}