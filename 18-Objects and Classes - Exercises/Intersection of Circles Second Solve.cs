class Program
{
    static void Main()
    {
        Circle circleOne = ReadCircle();
        Circle circleTwo = ReadCircle();
        double distance = CalculateDistance(circleOne, circleTwo);
        var intersect = Intersect(circleOne, circleTwo, distance);
        PrintResult(intersect);
    }

    static void PrintResult(bool intersect)
    {
        if (intersect)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static bool Intersect(Circle circleOne, Circle circleTwo, double distance)
    {
        var radiuses = circleOne.Radius + circleTwo.Radius;

        if (distance <= radiuses)
        {
            return true;
        }

        return false;
    }

    static double CalculateDistance(Circle circleOne, Circle circleTwo)
    {
        double deltaX = Math.Pow(circleOne.Center.X - circleTwo.Center.X, 2);
        double deltaY = Math.Pow(circleOne.Center.Y - circleTwo.Center.Y, 2);
        double distanceBetween = Math.Sqrt(deltaX + deltaY);
        return distanceBetween;
    }

    static Circle ReadCircle()
    {
        int[] tokens = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int x = tokens[0];
        int y = tokens[1];
        int radius = tokens[2];

        Point point = new Point(x, y);
        Circle circle = new Circle(point, radius);
        return circle;
    }

    class Point
    {
        public Point() { }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

    }

    class Circle
    {
        public Circle() { }
        public Circle(Point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;
        }
        public Point Center { get; set; }
        public int Radius { get; set; }
    }
}