decimal money = decimal.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
decimal lightSaber = decimal.Parse(Console.ReadLine());
decimal robesPrice = decimal.Parse(Console.ReadLine());
decimal beltsPrice = decimal.Parse(Console.ReadLine());

decimal tenPercen = (decimal)(studentsCount * 10) / 100;
decimal sabersTotalPrice = lightSaber * Math.Ceiling(studentsCount + tenPercen);
decimal beltsTotalPrice = beltsPrice * studentsCount;

for (int i = 1; i <= studentsCount; i++)
{
    if (i % 2 == 0 &&
        i % 3 == 0)
    {
        beltsTotalPrice -= beltsPrice;
    }
}
decimal robesTotalPrice = robesPrice * studentsCount;
decimal equipmentPrice = (robesTotalPrice + beltsTotalPrice + sabersTotalPrice);
if (money >= equipmentPrice)
{
    Console.WriteLine($"The money is enough - it would cost {equipmentPrice:f2}lv.");
}
else
{
    decimal requiredMoney = equipmentPrice - money;
    Console.WriteLine($"John will need {requiredMoney:f2}lv more.");
}