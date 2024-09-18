class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = GetPercentage(price, nextPrice);

            bool isSignificantDifference = IsEnoughDifference(difference, threshold);

            string message = GetDifference(nextPrice, price, difference, isSignificantDifference);
            Console.WriteLine(message);

            price = nextPrice;
        }
    }

    private static string GetDifference(double nextPrice, double price, double difference, bool etherTrueOrFalse)

    {
        string result = "";
        difference *= 100;
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", nextPrice);
        }
        else if (!etherTrueOrFalse)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference);
        }
        return result;
    }
    private static bool IsEnoughDifference(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double GetPercentage(double price, double nextPrice)
    {
        double difference = (nextPrice - price) / price;
        return difference;
    }
}