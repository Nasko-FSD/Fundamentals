double money = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double lightSaber = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice = double.Parse(Console.ReadLine());

double sabersTotalPrice = lightSaber * Math.Ceiling(studentsCount * 0.1 + studentsCount);
double beltsTotalPrice = beltsPrice * studentsCount;
double robesTotalPrice = robesPrice * studentsCount;

for (int i = 1; i <= studentsCount; i++)
{
    if (i % 6 == 0)
    {
        beltsTotalPrice -= beltsPrice;
    }
}

double equipmentPrice = robesTotalPrice + beltsTotalPrice + sabersTotalPrice;
if (money >= equipmentPrice)
{
    Console.WriteLine($"The money is enough - it would cost {equipmentPrice:f2}lv.");
}
else
{
    double requiredMoney = equipmentPrice - money;
    Console.WriteLine($"John will need {requiredMoney:f2}lv more.");
}