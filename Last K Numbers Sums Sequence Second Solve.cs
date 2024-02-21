int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

long[] numbers = new long[n];
numbers[0] = 1;

SumLastKNumbers(numbers, k);
Console.WriteLine(string.Join(" ", numbers));

static void SumLastKNumbers(long[] numbers, int k)
{
    for (int currenElement = 1; currenElement < numbers.Length; currenElement++)
    {
        int startIndex = Math.Max(0, currenElement - k);

        long sum = 0;

        for (int j = startIndex; j <= currenElement; j++)
        {
            sum += numbers[j];
        }

        numbers[currenElement] = sum;

    }
}