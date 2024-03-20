List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
string[] commands = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int takeElement = int.Parse(commands[0]);
int deleteElement = int.Parse(commands[1]);
int findElement = int.Parse(commands[2]);
int counter = 0;

for (int i = 0; i < deleteElement; i++)
{
    for (int j = 0; j < numbers.Count; j++)
    {
        if (i == j)
        {
            numbers.RemoveAt(i);
            counter++;
            if (counter == deleteElement)
            {
                break;
            }
            j--;
            if (j < 0)
            {
                j = -1;
            }
        }
    }
    break;
}

bool foundElement = false;
for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == findElement)
    {
        foundElement = true;
        break;
    }
}
if (foundElement)
{
    Console.WriteLine("YES!");
}
else
{
    Console.WriteLine("NO!");
}