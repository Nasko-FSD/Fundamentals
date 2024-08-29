string snowWhite = "";
Dictionary<string, Dictionary<string, int>> dwarfsCollection = new Dictionary<string, Dictionary<string, int>>();

while ((snowWhite = Console.ReadLine()) != "Once upon a time")
{
    string[] dwarfData = snowWhite
        .Split(new[] { " <:> " }, StringSplitOptions.None).ToArray();

    string dwarfName = dwarfData[0];
    string dwarfHatColor = dwarfData[1];
    int dwarfPhysics = int.Parse(dwarfData[2]);

    if (dwarfsCollection.ContainsKey(dwarfHatColor) == false)
    {
        dwarfsCollection.Add(dwarfHatColor, new Dictionary<string, int>());
    }

    if (dwarfsCollection[dwarfHatColor].ContainsKey(dwarfName) == false)
    {
        dwarfsCollection[dwarfHatColor].Add(dwarfName, dwarfPhysics);
    }

    if (dwarfsCollection[dwarfHatColor][dwarfName] < dwarfPhysics)
    {
        dwarfsCollection[dwarfHatColor][dwarfName] = dwarfPhysics;
    }
}
Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
foreach (var hatColor in dwarfsCollection.OrderByDescending(x => x.Value.Count()))
{
    foreach (var dwarf in hatColor.Value)
    {
        sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
    }
}
foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
{
    Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
}