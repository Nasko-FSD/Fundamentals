int totalSnowballs = int.Parse(Console.ReadLine());
double snowballValue = 0;
double oldValue = -1;
int snowballSnow = 0;
int snowballTime = 0;
int snowballQuality = 0;
int oldSnowballQuality = 0;
int oldSnowballSnow = 0;
int oldSnowballTime = 0;
for (int i = 0; i < totalSnowballs; i++)
{
    snowballSnow = int.Parse(Console.ReadLine());
    snowballTime = int.Parse(Console.ReadLine());
    snowballQuality = int.Parse(Console.ReadLine());

    snowballValue = Math.Pow(snowballSnow / snowballTime, snowballQuality);

    if (snowballValue > oldValue)
    {
        oldValue = snowballValue;
        oldSnowballQuality = snowballQuality;
        oldSnowballSnow = snowballSnow;
        oldSnowballTime = snowballTime;
    }
}
Console.WriteLine($"{oldSnowballSnow} : {oldSnowballTime} = {oldValue} ({oldSnowballQuality})");