string[] lines = File.ReadAllLines("Input.txt");

for (int i = 0; i < lines.Length; i++)
{
    lines[i] = i+1 + ". " + lines[i];

    File.WriteAllLines("Insert Line Numbers.txt", lines);
}