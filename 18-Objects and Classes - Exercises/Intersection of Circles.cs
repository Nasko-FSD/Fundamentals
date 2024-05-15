class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Program
{
    static void Main()
    {
        Circle circleOne = ReadCoordinates();
        Circle circleTwo = ReadCoordinates();
        bool result = Intersect(circleOne, circleTwo);
        PrintResult(result);
    }    
    static void PrintResult(bool Intersect)
    {
        if (Intersect)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    static bool Intersect(Circle circleOne, Circle circleTwo)
    {
        var distance = CalculateDistance(circleOne.Center, circleTwo.Center);
        var sumRadiuses = circleOne.Radius + circleTwo.Radius;
        if (distance <= sumRadiuses)
        {
            return true;
        }

        return false;
    }

    static double CalculateDistance(Point point1, Point point2)
    {
        var pointX = Math.Pow(point1.X - point2.X, 2);
        var pointY = Math.Pow(point1.Y - point2.Y, 2);
        var distance = Math.Sqrt(pointX + pointY);
        return distance;
    }

    static Circle ReadCoordinates()
    {
        int[] coordinates = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Circle circle = new Circle();
        Point point = new Point();
        point.X = coordinates[0];
        point.Y = coordinates[1];
        circle.Center = point;
        circle.Radius = coordinates[2];
        return circle;
    }
}