string inputText = Console.ReadLine();
char[] stringArray = inputText.ToCharArray();
Array.Reverse(stringArray);
string reversed = new string(stringArray);
Console.WriteLine(reversed);