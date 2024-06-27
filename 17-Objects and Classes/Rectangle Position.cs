class Rectangle
{
    public int Top { get; set; } 
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }
    public int Right 
    {
        get
        {
            return Left + Width;
        }
    }

    public bool IsInside(Rectangle outer)
    {
        return
            outer.Left <= Left &&
            outer.Right >= Right &&
            outer.Top <= Top &&
            outer.Bottom >= Bottom;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangleOne = ReadPoints();
        Rectangle rectangleTwo = ReadPoints();
        Rectangle makeAcheck = InorOut(rectangleOne, rectangleTwo);
        Console.WriteLine(makeAcheck);
    }

    static Rectangle InorOut(Rectangle rectangleOne, Rectangle rectangleTwo)
    {
        Rectangle result = null;
        if (rectangleOne.IsInside(rectangleTwo))
        {
            Console.Write("Inside");
        }
        else
        {
            Console.Write("Not inside");
        }
        return result;
    }

    static Rectangle ReadPoints()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Rectangle points = new Rectangle() { Left = numbers[0], Top = numbers[1], Width = numbers[2], Height = numbers[3] };
        return points;
    }
}