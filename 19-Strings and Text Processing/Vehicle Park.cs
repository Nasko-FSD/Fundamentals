List<string> availableVehicles = Console.ReadLine().Split(' ').ToList();
string customerRequest = Console.ReadLine();
int vehiclesSold = 0;
while (customerRequest != "End of customers!")
{
    string[] data = customerRequest.Split(' ');
    string formattedData = data[0].ToLower()[0] + data[2];
    int wantedVehicle = 0;
    for (int i = 0; i < availableVehicles.Count; i++)
    {
        if (formattedData == availableVehicles[i])
        {
            wantedVehicle = i;
            break;
        }
    }
    if (wantedVehicle == 0)
    {
        Console.WriteLine("No");
    }
    else
    {
        string vehicle = availableVehicles[wantedVehicle];
        int price = vehicle[0] * int.Parse(vehicle.Substring(1, vehicle.Length - 1));
        Console.WriteLine("Yes, sold for {0}$", price);
        vehiclesSold++;
        availableVehicles.RemoveAt(wantedVehicle);
    }
    customerRequest = Console.ReadLine();
}
Console.WriteLine("Vehicles left: {0}", string.Join(", ", availableVehicles));
Console.WriteLine("Vehicles sold: {0}", vehiclesSold);