string[] lines = File.ReadAllLines("Input.txt");

File.Delete("odd-lines.txt");

for (int i = 1; i < lines.Length; i+= 2)
{
    File.AppendAllText("odd-lines.txt",
        lines[i] +Environment.NewLine);
}