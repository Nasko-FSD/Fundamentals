string[] lines = File.ReadAllLines("Input.txt");

var oddLines = lines
    .Where((line, index) => index % 2 == 1)
    .ToArray();

File.WriteAllLines("odd-lines.txt", oddLines);