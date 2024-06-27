
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString() 
    {
        return "Point(" + X + ", " + Y + ")"; 
    }
}
class ClosestTwoPoints
{
    public Point p1 { get; set; } 
    public Point p2 { get; set; }
    public double Distance { get; set; } 
}
class Example
{
    static void Main()
    {
        Point[] points = ReadPoints();
        var closestTwoPoints = FindClosestTwoPoints(points);

        Console.WriteLine("{0:f3}", closestTwoPoints.Distance);
        Console.WriteLine(closestTwoPoints.p1);
        Console.WriteLine(closestTwoPoints.p2);
    }

    static ClosestTwoPoints FindClosestTwoPoints(Point[] points)
    {
        var minDistance = double.MaxValue;
        ClosestTwoPoints result = null;
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                var distance = CalculateDistance(points[i], points[j]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    result = new ClosestTwoPoints()
                    {
                        p1 = points[i],
                        p2 = points[j],
                        Distance = distance
                    };
                }
            }
        }
        return result;
    }

    static Point[] ReadPoints() 
    {
        var n = int.Parse(Console.ReadLine());
        var points = new Point[n]; 
        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPoint();
        }
        return points;
    }

    static Point ReadPoint()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point p = new Point() { X = numbers[0], Y = numbers[1] };
        return p;
    }

    static double CalculateDistance(Point p1, Point p2)
    {
        var deltaX = p1.X - p2.X;
        var deltaY = p1.Y - p2.Y;
        var distanceBetween = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return distanceBetween;
    }
}
