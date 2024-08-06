string[] fileOnePath = File.ReadAllLines("FileOne.txt");
string[] fileTwoPath = File.ReadAllLines("FileTwo.txt");

File.WriteAllText("Output.txt", string.Empty);

int maxLength = Math.Max(fileOnePath.Length, fileTwoPath.Length);

using (StreamWriter writer = new StreamWriter("Output.txt", append: true))
{
    for (int i = 0; i < maxLength; i++)
    {
        if (i < fileOnePath.Length)
        {
            writer.WriteLine(fileOnePath[i]);
        }
        if (i < fileTwoPath.Length)
        {
            writer.WriteLine(fileTwoPath[i]);
        }
    }
}