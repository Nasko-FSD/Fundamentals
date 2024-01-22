int groupSize = int.Parse(Console.ReadLine());
string packageType = Console.ReadLine().ToLower();
string hall = "";
double smallHallPrice = 2500;
double TerracePrice = 5000;
double greatHallPrice = 7500;
double normalDiscount = 500;
double goldDiscount = 750;
double platinumDiscount = 1000;
double totalPrice = 0;
if (groupSize <= 50 || groupSize < 120)
{
    if (groupSize <= 50)
    {
        if (packageType == "normal")
        {
            smallHallPrice += normalDiscount;
            smallHallPrice = smallHallPrice - (smallHallPrice * 5 / 100);
            totalPrice = smallHallPrice / groupSize;
        }
        else if (packageType == "gold")
        {
            smallHallPrice += goldDiscount;
            smallHallPrice = smallHallPrice - (smallHallPrice * 10 / 100);
            totalPrice = smallHallPrice / groupSize;
        }
        else
        {
            smallHallPrice += platinumDiscount;
            smallHallPrice = smallHallPrice - (smallHallPrice * 15 / 100);
            totalPrice = smallHallPrice / groupSize;
        }
        hall = "Small Hall";
    }
    else if (groupSize > 50 && groupSize <= 100)
    {
        if (packageType == "normal")
        {
            TerracePrice += normalDiscount;
            TerracePrice = TerracePrice - (TerracePrice * 5 / 100);
            totalPrice = TerracePrice / groupSize;
        }
        else if (packageType == "gold")
        {
            TerracePrice += goldDiscount;
            TerracePrice = TerracePrice - (TerracePrice * 10 / 100);
            totalPrice = TerracePrice / groupSize;
        }
        else
        {
            TerracePrice += platinumDiscount;
            TerracePrice = TerracePrice - (TerracePrice * 15 / 100);
            totalPrice = TerracePrice / groupSize;
        }
        hall = "Terrace";
    }
    else if (groupSize > 100 && groupSize <= 120)
    {
        if (packageType == "normal")
        {
            greatHallPrice += normalDiscount;
            greatHallPrice = greatHallPrice - (greatHallPrice * 5 / 100);
            totalPrice = greatHallPrice / groupSize;
        }
        else if (packageType == "gold")
        {
            greatHallPrice += goldDiscount;
            greatHallPrice = greatHallPrice - (greatHallPrice * 10 / 100);
            totalPrice = greatHallPrice / groupSize;
        }
        else
        {
            greatHallPrice += platinumDiscount;
            greatHallPrice = greatHallPrice - (greatHallPrice * 15 / 100);
            totalPrice = greatHallPrice / groupSize;
        }
        hall = "Great Hall";
    }
    Console.WriteLine($"We can offer you the {hall}");
    Console.WriteLine($"The price per person is {totalPrice:f2}$");
}
else if (groupSize > 120)
{
    Console.WriteLine("We do not have an appropriate hall.");
}