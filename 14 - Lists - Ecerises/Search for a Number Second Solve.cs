List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string[] commands = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int takeElement = int.Parse(commands[0]);
int deleteElement = int.Parse(commands[1]);
int findElement = int.Parse(commands[2]);

for (int i = 0; i < deleteElement; i++)
{
    numbers.RemoveAt(0);
}

bool elementFound = false;
foreach (int num in numbers)
{
    if (num == findElement)
    {
        elementFound = true;
        break;
    }
}

if (elementFound)
{
    Console.WriteLine("YES!");
}
else
{
    Console.WriteLine("NO!");
}