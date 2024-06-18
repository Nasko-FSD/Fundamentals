using System.Globalization;
class Program
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            this.AllComments = new List<string>();
            this.AllDates = new List<DateTime>();
        }

        public List<string> AllComments { get; set; }
        public List<DateTime> AllDates { get; set; }
        public string Name { get; set; }
    }

    static void Main()
    {
        Dictionary<string, Student> allStudents = ReadDates();
        Dictionary<string, List<string>> allComments = ReadComments(allStudents);
        PrintResult(allStudents, allComments);
    }

    static void PrintResult(Dictionary<string, Student> allStudents, Dictionary<string, List<string>> allComments)
    {
        foreach (var user in allStudents.OrderBy(x => x.Key))
        {
            Console.WriteLine(user.Key);
            Console.WriteLine("Comments:");
            foreach (var comment in user.Value.AllComments)
            {
                Console.WriteLine("- {0}", comment);
            }
            Console.WriteLine("Dates attended:");
            foreach (var date in user.Value.AllDates.OrderBy(x => x))
            {
                string allDates = date.ToString("dd/MM/yyyy");
                Console.WriteLine($"-- {allDates}");
            }
        }
    }

    static Dictionary<string, List<string>> ReadComments(Dictionary<string, Student> allStudents)
    {
        Dictionary<string, List<string>> comments = new Dictionary<string, List<string>>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of comments")
            {
                break;
            }
            string[] inputData = inputLine
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string user = inputData[0];
            string allComments = inputData[1];
            if (allStudents.ContainsKey(user))
            {
                if (comments.ContainsKey(user) == false)
                {
                    comments.Add(user, new List<string>());
                }
                comments[user].Add(allComments);
                allStudents[user].AllComments.Add(allComments);
            }
        }
        return comments;
    }

    static Dictionary<string, Student> ReadDates()
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of dates")
            {
                break;
            }
            string[] inputData = inputLine.
                Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string name = inputData[0];
            List<DateTime> dates = new List<DateTime>();
            if (inputData.Length > 1)
            {
                for (int i = 1; i < inputData.Length; i++)
                {
                    dates.Add(DateTime.ParseExact(inputData[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
            }
            Student studentDates = new Student(name) { AllDates = dates };
            if (students.ContainsKey(name) == false)
            {
                students.Add(name, studentDates);
            }
            else
            {
                students[name].AllDates.AddRange(dates);
            }
        }
        return students;
    }
}