Point p1 = ReadPoint();
Point p2 = ReadPoint();
PrintResult(p1, p2);
static void PrintResult(Point p1, Point p2)
{
    double result = CalculateDistance(p1, p2);
    Console.WriteLine($"{result:f3}");
}
static Point ReadPoint()
{
    int[] inputData = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    Point point = new Point();
    point.X = inputData[0];
    point.Y = inputData[1];
    return point;

}
static double CalculateDistance(Point p1, Point p2)
{
    double sideA = p1.X - p2.X;
    double sideB = p1.Y - p2.Y;
    double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
    return distance;
}
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}