class Program
{
    static void Main()
    {
        List<Student> students = ReadStudents();
        List<Student> sortedStudents = OrderScores(students);
        PrintResult(sortedStudents);
    }

    static void PrintResult(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} -> {student.AverageGrades:f2}");
        }
    }

    static List<Student> OrderScores(List<Student> students)
    {
        return students.Where(s => s.AverageGrades >= 5.00)
            .OrderBy(s => s.Name)
            .ThenByDescending(s => s.AverageGrades)
            .ToList();
    }

    static List<Student> ReadStudents()
    {
        int number = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();
        for (int i = 0; i < number; i++)
        {
            string[] studentData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string name = studentData[0];
            List<double> grades = studentData.Skip(1).Select(double.Parse).ToList();
            Student student = new Student(name, grades);
            students.Add(student);
        }
        return students;
    }
    class Student
    {
        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
            this.AverageGrades = grades.Average();
        }
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades { get; set; }
    }
}