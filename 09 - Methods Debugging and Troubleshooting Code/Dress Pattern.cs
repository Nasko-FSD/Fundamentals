var n = int.Parse(Console.ReadLine());
var totalWidth = 12 * n + 2;
var sleeveArmpitWidth = 3 * n;

//Top
var stars = 2;
var lowerCases = (totalWidth / 3);
Console.Write(new string('_', lowerCases));
Console.Write(".");
Console.Write(new string('_', lowerCases));
Console.Write(".");
Console.WriteLine(new string('_', lowerCases));
lowerCases = (totalWidth / 3) - 2;
for (int top = 0; top < (n * 2) - 1; top++)
{
    Console.Write(new string('_', lowerCases));
    Console.Write(".");
    Console.Write(new string('*', stars));
    Console.Write(".");
    Console.Write(new string('_', lowerCases));
    Console.Write(".");
    Console.Write(new string('*', stars));
    Console.Write(".");
    Console.WriteLine(new string('_', lowerCases));
    stars += 3;
    lowerCases -= 2;
}

//Sleeves
Console.Write(".");
Console.Write(new string('*', stars));
Console.Write("..");
Console.Write(new string('*', stars));
Console.WriteLine(".");
for (int sleeves = 0; sleeves < n; sleeves++)
{
    Console.Write(".");
    Console.Write(new string('*', stars * 2 + 2));
    Console.WriteLine(".");
}
Console.Write(new string('.', sleeveArmpitWidth));
Console.Write(new string('*', totalWidth - 2 * sleeveArmpitWidth));
Console.WriteLine(new string('.', sleeveArmpitWidth));

//Belt
for(int belt = 0; belt < n; belt++)
{
    Console.Write(new string('_', n * 3));
    Console.Write(new string('o', totalWidth - 2 * (n * 3)));
    Console.WriteLine(new string('_', n * 3));
}

//Bottom
var bottomWidth = totalWidth - 2 * (n * 3) - 2;
var underscores = n * 3;
for (int bottom = 0; bottom < n * 3; bottom++)
{
    Console.Write(new string('_', underscores));
    Console.Write(".");
    Console.Write(new string('*', bottomWidth));
    Console.Write(".");
    Console.WriteLine(new string('_', underscores));
    underscores--;
    bottomWidth += 2;
}
Console.WriteLine(new string('.', totalWidth));