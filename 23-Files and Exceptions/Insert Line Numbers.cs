string[] lines = File.ReadAllLines("Input.txt");

var numeric = lines
    .Select((line, index) => (index + 1) + ". " + line)
    .ToArray();

File.WriteAllLines("output.txt", numeric);