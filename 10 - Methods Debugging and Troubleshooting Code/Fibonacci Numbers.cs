int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int result = Fib(number);
Console.WriteLine(result);

static int Fib(int number)
{
    int result = 1;
    int fibonacci0 = 1;
    int fibonacci1 = 1;
    for (int i = 0; i < number - 1; i++)
    {
        int fibonacciNext = fibonacci0 + fibonacci1;
        fibonacci0 = fibonacci1;
        fibonacci1 = fibonacciNext;
        result = fibonacci1;
    }
    return result;
}