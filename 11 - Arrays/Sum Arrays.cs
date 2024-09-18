var array1 = Console.ReadLine().Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var array2 = Console.ReadLine().Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var largestLength = Math.Max(array1.Length, array2.Length);
var sumArr = new int[largestLength];
for (int i = 0; i < largestLength; i++)
{
    int firstValue = array1[i % array1.Length];
    int secondValue = array2[i % array2.Length];
    Console.Write($"{firstValue + secondValue} ");
}