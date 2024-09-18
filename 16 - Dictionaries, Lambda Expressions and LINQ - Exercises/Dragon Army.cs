class Program
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, Dragon>> army = new Dictionary<string, SortedDictionary<string, Dragon>>();
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
            string armorString =  data[4];

            int damage;
            try
            {
                damage = int.Parse(damageString);
            }
            catch (Exception)
            {
                damage = 45;
            }
            if (int.TryParse(healthString, out int health) == false)
            {
                health = 250;
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
            Dragon dragon = new Dragon()
            {
                Name = name,
                Damage = damage,
                Health = health,
                Armor = armor
            };
            if (army.ContainsKey(type) == false)
            {
                army.Add(type, new SortedDictionary<string, Dragon>());
            }
            // type -> < name, new Dragon>
            army[type][dragon.Name] = dragon;
        }
        //Printing
        foreach (var t in army)
        {
            //.Value because we have SortedDictionary<string, Dragon> and .Value access Dragon
            var damageAv = t.Value.Select(d => d.Value.Damage).Average();
            var healthAv = t.Value.Select(d => d.Value.Health).Average();
            var armorAv = t.Value.Select(d => d.Value.Armor).Average();

            Console.WriteLine($"{t.Key}::({damageAv:f2}/{healthAv:f2}/{armorAv:f2})");

            foreach (var d in t.Value.OrderBy(d => d.Value.Name))
            {
                Console.WriteLine($"-{d.Value.Name} -> damage: {d.Value.Damage}, health: {d.Value.Health}, armor: {d.Value.Armor}");
            }
        }
    }
    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
    }
}