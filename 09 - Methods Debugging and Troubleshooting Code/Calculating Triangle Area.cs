CalculatingTriangleArea();

static void CalculatingTriangleArea()
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double area = (a * b) / 2;
    Console.WriteLine(area);
}