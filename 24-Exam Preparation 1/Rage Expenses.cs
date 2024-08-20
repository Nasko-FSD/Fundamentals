int lostGamesCOunter = int.Parse(Console.ReadLine());
decimal headset = decimal.Parse(Console.ReadLine());
decimal mouse = decimal.Parse(Console.ReadLine());
decimal keyboard = decimal.Parse(Console.ReadLine());
decimal display = decimal.Parse(Console.ReadLine());

decimal totalSum = 0;
int keyboardCounter = 0;

for (int i = 1; i <= lostGamesCOunter; i++)
{
    if (i % 2 == 0)
    {
        totalSum += headset;
    }
    if (i % 3 == 0)
    {
        totalSum += mouse;
    }
    if (i % 2 == 0 && 
             i % 3 == 0)
    {
        keyboardCounter++;
        totalSum += keyboard;

        if (keyboardCounter % 2 == 0 && 
            keyboardCounter > 0)
        {
            totalSum += display;
        }
    }
}
Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");