using System.Globalization;

class Program
{
    class Dates
    {
        public Dates(string userName, List<DateTime> userDates)
        {
            UserName = userName;
            UserDates = userDates;
        }

        public string UserName { get; set; }
        public List<DateTime> UserDates { get; set; }
    }
    class Comments
    {
        public Comments(string userNames, List<string> commentsList)
        {
            UserNames = userNames;
            CommentsList = commentsList;
        }

        public string UserNames { get; set; }
        public List<string> CommentsList { get; set; }
    }
    static void Main()
    {
        List<Dates> dates = ReadDates();
        List<Comments> comments = ReadComments(dates);
        PrintResult(dates, comments);
    }

    static void PrintResult(List<Dates> dates, List<Comments> comments)
    {
        foreach (Dates user in dates.OrderBy(d => d.UserName))
        {
            Console.WriteLine(user.UserName);
            Console.WriteLine("Comments:");
            foreach (var comment in comments.Where(c => c.UserNames == user.UserName).SelectMany(c => c.CommentsList))
            {
                Console.WriteLine($"- {comment}");
            }
            Console.WriteLine("Dates attended:");
            foreach (var date in user.UserDates.OrderBy(d => d))
            {
                string allDates = date.ToString("dd/MM/yyyy");
                Console.WriteLine($"-- {allDates}");
            }
        }
    }

    static List<Comments> ReadComments(List<Dates> dates)
    {
        List<Comments> comments = new List<Comments>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of comments")
            {
                break;
            }
            string[] inputData = inputLine
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string userNames = inputData[0];
            string comment = inputData[1];
            if (dates.Any(u => u.UserName == userNames) == false)
            {
                continue;
            }
            Comments coment = comments
                .FirstOrDefault(u => u.UserNames == userNames);
            if (coment == null)
            {
                List<string> userComments = new List<string> { comment };
                Comments newComment = new Comments(userNames, userComments);
                comments.Add(newComment);
            }
            else
            {
                coment.CommentsList.Add(comment);
            }
        }
        return comments;
    }

    static List<Dates> ReadDates()
    {
        List<Dates> dates = new List<Dates>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of dates")
            {
                break;
            }
            string[] inputData = inputLine
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string userName = inputData[0];
            List<DateTime> userDates = new List<DateTime>();
            if (inputData.Length > 1)
            {
                for (int i = 1; i < inputData.Length; i++)
                {
                    userDates.Add(DateTime.ParseExact(inputData[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
            }
            Dates date = dates
                .FirstOrDefault(d => d.UserName == userName);
            if (date == null)
            {
                Dates newDate = new Dates(userName, userDates);
                dates.Add(newDate);
            }
            else
            {
                date.UserDates.AddRange(userDates);
            }
        }
        return dates;
    }
}