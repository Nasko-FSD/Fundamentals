class Program
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, Dragon>> allDragons = ReadDragons();
        PrintDragons(allDragons);
    }

    static void PrintDragons(Dictionary<string, SortedDictionary<string, Dragon>> allDragons)
    {
        foreach (var type in allDragons)
        {
            var damageAv = type.Value.Select(d => d.Value.Damage).Average();
            var healthAv = type.Value.Select(d => d.Value.Health).Average();
            var armorAv = type.Value.Select(d => d.Value.Armor).Average();

            Console.WriteLine($"{type.Key}::({damageAv:f2}/{healthAv:f2}/{armorAv:f2})");

            foreach (var d in type.Value.OrderBy(d => d.Key))
            {
                Console.WriteLine($"-{d.Key} -> damage: {d.Value.Damage}, health: {d.Value.Health}, armor: {d.Value.Armor}");
            }
        }
    }

    static Dictionary<string, SortedDictionary<string, Dragon>> ReadDragons()
    {
        Dictionary<string, SortedDictionary<string, Dragon>> armyDragons = new Dictionary<string, SortedDictionary<string, Dragon>>();
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string[] data = input
                .Split();
            string type = data[0];
            string name = data[1];
            string damageString = data[2];
            string healthString = data[3];
            string armorString = data[4];

            int damage;
            if (damageString == "null")
            {
                damage = 45;
            }
            else
            {
                damage = int.Parse(damageString);
            }
            int health;
            if (healthString == "null")
            {
                health = 250;
            }
            else
            {
                health = int.Parse(healthString);
            }
            int armor;
            if (armorString == "null")
            {

                armor = 10;
            }
            else
            {
                armor = int.Parse(armorString);
            }
            Dragon dragon = new Dragon(damage, armor, health);
            if (armyDragons.ContainsKey(type) == false)
            {
                armyDragons.Add(type, new SortedDictionary<string, Dragon>());
            }
            armyDragons[type][name] = dragon;
        }
        return armyDragons;
    }

    class Dragon
    {
        public Dragon(int damage, int armor, int health)
        {
            Damage = damage;
            Armor = armor;
            Health = health;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
    }
}