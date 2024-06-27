Point[] points = ReadPoints();
Point[] closestPoints = FindClosestTwoPoints(points);

PrintDistance(closestPoints);

PrintPoint(closestPoints[0]);
PrintPoint(closestPoints[1]);
static Point[] ReadPoints()
{
    var numberOfPoints = int.Parse(Console.ReadLine());
    var points = new Point[numberOfPoints];

    for (int i = 0; i < numberOfPoints; i++)
    {
        points[i] = ReadPoint();
    }
    return points;
}

static Point ReadPoint()
{
    var numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    Point point = new Point();
    point.X = numbers[0];
    point.Y = numbers[1];
    return point;
}

static double CalculateDistance(Point point1, Point point2)
{
    var sideA = point1.X - point2.X;
    var sideB = point1.Y - point2.Y;
    var distanceBetween = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
    return distanceBetween;
}

static Point[] FindClosestTwoPoints(Point[] points)
{
    double minDistance = double.MaxValue;
    Point[] closestTwoPoints = null;

    for (int point1 = 0; point1 < points.Length; point1++)
    {
        for (int point2 = point1 + 1; point2 < points.Length; point2++)
        {
            double distance = CalculateDistance(points[point1], points[point2]);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestTwoPoints = new Point[] { points[point1], points[point2] };
            }
        }
    }
    return closestTwoPoints;
}

static void PrintPoint(Point point)
{
    Console.WriteLine($"({point.X}, {point.Y})");
}

static void PrintDistance(Point[] points)
{
    double distance = CalculateDistance(points[0], points[1]);
    Console.WriteLine($"{distance:f3}");
}
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

}

class closestTwoPoints
{
    public Point point1 { get; set; }
    public Point point2 { get; set; }
    public double Distance { get; set; }
}
