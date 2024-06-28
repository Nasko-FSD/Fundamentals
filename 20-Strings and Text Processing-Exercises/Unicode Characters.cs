using System.Text;

string inputText = Console.ReadLine();
StringBuilder sb = new StringBuilder();

foreach (char c in inputText)
{
    sb.Append("\\u");
    sb.Append(String.Format("{0:x4}", (int)c));
}
Console.Write(sb);