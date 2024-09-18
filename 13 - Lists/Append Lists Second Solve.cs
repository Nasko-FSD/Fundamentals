var lists = Console.ReadLine().Split('|').ToList();
var result = new List<string>();
for (int i = lists.Count - 1; i >= 0; i --)
{
    var currentList = lists[i].Split(' ');
    foreach(var item in currentList)
    {
        if (item != "")
        {
            result.Add(item);
        }
    }
}
Console.WriteLine(string.Join(" ", result));