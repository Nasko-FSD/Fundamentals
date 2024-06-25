using System.Diagnostics;
using System.Text;
Stopwatch timer = new Stopwatch();
timer.Start();
StringBuilder sB = new StringBuilder();
for (int i = 0; i < 50000; i++)
{
    sB.Append(Convert.ToString(i, 2));
}
Console.WriteLine(sB.Length);
Console.WriteLine(timer.Elapsed);