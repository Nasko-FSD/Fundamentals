class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> allPerformers = ReadPerformers();
        PrintPerformers(allPerformers);
    }

    static void PrintPerformers(Dictionary<string, Dictionary<string, int>> allPerformers)
    {
        foreach (var venue in allPerformers)
        {
            Console.WriteLine(venue.Key);
            foreach (var performer in venue.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {performer.Key}-> {performer.Value}");
            }
        }
    }

    static Dictionary<string, Dictionary<string, int>> ReadPerformers()
    {
        Dictionary<string, Dictionary<string, int>> venueSingerIncome = new Dictionary<string, Dictionary<string, int>>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "End")
            {
                break;
            }
            string[] input = inputLine.Split('@');
            string venue = "";
            string singer = "";
            int ticketPrice = 0;
            int ticketCount = 0;
            int totalIncome = 0;
            try
            {
                singer = input[0];
                if (singer.EndsWith(" ") == false)
                {
                    continue;
                }
                List<string> theRest = input[1].Split(' ').ToList();
                ticketCount = int.Parse(theRest[theRest.Count - 1]);
                theRest.RemoveAt(theRest.Count - 1);
                ticketPrice = int.Parse(theRest[theRest.Count - 1]);
                theRest.RemoveAt(theRest.Count - 1);
                totalIncome = ticketCount * ticketPrice;
                venue = string.Join(" ", theRest);
            }
            catch (Exception)
            {
                continue;
            }
            if (venueSingerIncome.ContainsKey(venue) == false)
            {
                venueSingerIncome.Add(venue, new Dictionary<string, int>());
            }
            if (venueSingerIncome[venue].ContainsKey(singer) == false)
            {
                venueSingerIncome[venue].Add(singer, 0);
            }
            venueSingerIncome[venue][singer] += totalIncome;
        }
        return venueSingerIncome;
    }
}