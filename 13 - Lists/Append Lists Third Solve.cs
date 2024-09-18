var lists = Console.ReadLine().Split('|').ToList();
var result = new List<string>();
for (int i = lists.Count - 1; i >= 0; i--)
{
    var currentList = lists[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    foreach (var item in currentList)
    {
        if (item != "") // Skips empty items
        {
            result.Add(item);
        }
    }
}
Console.WriteLine(string.Join(" ", result));