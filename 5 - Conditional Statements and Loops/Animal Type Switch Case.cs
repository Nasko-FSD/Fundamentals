string Animal = Console.ReadLine().ToLower();
switch (Animal)
{
    case "dog":
        Console.WriteLine("mammal"); break;
    case "crocodile":
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile"); break;
    default: Console.WriteLine("unknown"); break;

}