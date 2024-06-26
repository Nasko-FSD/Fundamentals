class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, ulong>> allArtists = ReadArtists();
        PrintIncome(allArtists);
    }

    static void PrintIncome(Dictionary<string, Dictionary<string, ulong>> allArtists)
    {
        foreach (var artist in allArtists)
        {
            Console.WriteLine(artist.Key);

            foreach (var name in artist.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {name.Key}-> {name.Value}");
            }
        }
    }

    static Dictionary<string, Dictionary<string, ulong>> ReadArtists()
    {
        Dictionary<string, Dictionary<string, ulong>> performerInfo = new Dictionary<string, Dictionary<string, ulong>>();

        while (true)
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "End")
            {
                break;
            }

            string[] checkInvalid = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string performer = "";
            string venue = "";
            ulong ticketPrice = 0;
            ulong ticketCount = 0;
            ulong totalCurrentProfit = 0;

            bool startsWithAt = false;

            foreach (var element in checkInvalid)
            {
                if (element.StartsWith("@"))
                {
                    startsWithAt = true;
                }
            }

            if (startsWithAt == false)
            {
                continue;
            }

            long digit;

            bool isDigit = long.TryParse(checkInvalid[checkInvalid.Length - 1], out digit);
            bool isDigit1 = long.TryParse(checkInvalid[checkInvalid.Length - 2], out digit);

            if (!isDigit || !isDigit1)
            {
                continue;
            }

            if (checkInvalid.Length < 4)
            {
                continue;
            }

            string[] arr = inputLine.Split('@');

            performer = arr[0];

            string[] venuePriceTickets = arr[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);


            ticketCount = ulong.Parse(venuePriceTickets[venuePriceTickets.Length - 1]);
            ticketPrice = ulong.Parse(venuePriceTickets[venuePriceTickets.Length - 2]);
            totalCurrentProfit = ticketPrice * ticketCount;

            string[] venueArr = venuePriceTickets.SkipLast(2).ToArray();

            venue = string.Join(" ", venueArr);

            if (performerInfo.ContainsKey(venue) == false)
            {
                performerInfo.Add(venue, new Dictionary<string, ulong>());
            }
            if (performerInfo[venue].ContainsKey(performer) == false)
            {
                performerInfo[venue].Add(performer, 0);
            }
            performerInfo[venue][performer] += totalCurrentProfit;
        }
        return performerInfo;
    }
}