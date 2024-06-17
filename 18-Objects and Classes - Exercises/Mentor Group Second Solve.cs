using System.Globalization;
class Program
{
    class Student
    {
        public Student(string name)
        {
            Comments = new List<string>();
            Dates = new List<DateTime>();
            Name = name;
        }

        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
        public string Name { get; set; }
    }
    static void Main()
    {
        Dictionary<string, Student> allStudents = ReadStudents();
        Dictionary<string, List<string>> allComments = ReadComments(allStudents);
        PrintResult(allStudents, allComments);
    }

    static void PrintResult(Dictionary<string, Student> allStudents, Dictionary<string, List<string>> allComments)
    {
        foreach (var user in allStudents.OrderBy(x => x.Key))
        {
            Console.WriteLine(user.Key);
            Console.WriteLine("Comments:");
            foreach (var comment in user.Value.Comments)
            {
                Console.WriteLine("- {0}", comment);
            }
            Console.WriteLine("Dates attended:");
            foreach (var date in user.Value.Dates.OrderBy(x => x))
            {
                string allDates = date.ToString("dd/MM/yyyy");
                Console.WriteLine($"-- {allDates}");
            }
        }
    }

    static Dictionary<string, List<string>> ReadComments(Dictionary<string, Student> allStudents)
    {
        var comments = new Dictionary<string, List<string>>();
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
            string comment = inputData[1];
            if (allStudents.ContainsKey(user))
            {
                if (comments.ContainsKey(user) == false)
                {
                    comments.Add(user, new List<string>());
                }
                comments[user].Add(comment);
                allStudents[user].Comments.Add(comment);
            }
        }
        return comments;
    }

    static Dictionary<string, Student> ReadStudents()
    {
        var students = new Dictionary<string, Student>();
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of dates")
            {
                break;
            }
            string[] inputData = inputLine.
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = inputData[0];
            List<string> dates = new List<string>();
            if (inputData.Length > 1)
            {
                dates = inputData[1].Split(',').ToList();
            }
            Student student = new Student(name);
            foreach (var date in dates)
            {
                student.Dates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
            }
            if (students.ContainsKey(name) == false)
            {
                students.Add(name, student);
            }
            else
            {
                students[name].Dates.AddRange(student.Dates);
            }
        }
        return students;
    }
}