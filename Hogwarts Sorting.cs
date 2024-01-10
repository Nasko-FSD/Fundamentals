int gryffindor = 0;
int slytherine = 0;
int ravenclaw = 0;
int hufflepuf = 0;

int numberOfSudents = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfSudents; i++)
{
    int sumOfAscii = 0;
    string[] namesOfStudents = Console.ReadLine().Split(' ');
    string firstName = namesOfStudents[0];
    string lastName = namesOfStudents[1];
    for (int firstNameLetters = 0; firstNameLetters < firstName.Length; firstNameLetters++)
    {
        sumOfAscii += firstName[firstNameLetters];
    }
    for (int lastNameLetters = 0; lastNameLetters < lastName.Length; lastNameLetters++)
    {
        sumOfAscii += lastName[lastNameLetters];
    }
    string facultyNumber = string.Format("{0}{1}{2}", sumOfAscii, firstName[0], lastName[0]);
    int reminder = sumOfAscii % 4;
    switch (reminder)
    {
        case 0:
            gryffindor++;
            Console.WriteLine("Gryffindor {0}", facultyNumber);
            break;
        case 1:
            slytherine++;
            Console.WriteLine("Slytherine {0}", facultyNumber);
            break;
        case 2:
            ravenclaw++;
            Console.WriteLine("Ravenclaw {0}", facultyNumber);
            break;
        case 3:
            hufflepuf++;
            Console.WriteLine("Hufflepuf {0}", facultyNumber);
            break;
    }
}
Console.WriteLine();
Console.WriteLine("Gryffindor: {0}", gryffindor);
Console.WriteLine("Slytherine: {0}", slytherine);
Console.WriteLine("Ravenclaw: {0}", ravenclaw);
Console.WriteLine("Hufflepuf: {0}", hufflepuf);