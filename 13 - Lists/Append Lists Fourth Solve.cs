var lists = Console.ReadLine().Split('|').ToList();
var result = new List<string>();
for (int i = lists.Count - 1; i >= 0; i--)
{
    var currentList = lists[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    for (int j = 0; j < currentList.Count; j++)
    {
        if (currentList.Count > 0) // Skips empty items
        {
            result.Add(currentList[j]);
        }
    }
}
Console.WriteLine(string.Join(" ", result));