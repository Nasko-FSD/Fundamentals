var lists = Console.ReadLine().Split('|').ToList();
for (int i = lists.Count - 1; i >= 0; i--)
{
    var currentList = lists[i].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
    foreach (var element in currentList)
    {
        Console.Write(element + " ");
    }
}