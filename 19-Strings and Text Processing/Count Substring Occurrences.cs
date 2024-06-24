string inputText = Console.ReadLine().ToLower();
string pattern = Console.ReadLine().ToLower();
int count = 0;
int index = inputText.IndexOf(pattern);//What we are searching
while( index != -1)
{
    count++;
    index = inputText.IndexOf(pattern, index+1);// If it's only one argument it starts from where we found the pattern
    // overflow

}
Console.WriteLine(count);