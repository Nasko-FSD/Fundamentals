string inputText = Console.ReadLine();
for (int i = 0; i < inputText.Length; i++)
{
    Console.Write("\\u{0:x4}", (int)inputText[i]);
}