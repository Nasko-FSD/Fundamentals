using System;
using System.Linq;
class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Right
    {
        get
        {
            return Left + Width;
        }
    }
    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }
    static void Main(string[] args)
    {
        Rectangle rectangleOne = ReadPoints();
        Rectangle rectangleTwo = ReadPoints();
        bool isInside = IsInside(rectangleOne, rectangleTwo);
        PrintResult(isInside);
    }
    static void PrintResult(bool isInside)
    {
        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }
    static bool IsInside(Rectangle rectangleOne, Rectangle rectangleTwo)
    {
        if (rectangleOne.Left >= rectangleTwo.Left &&
            rectangleOne.Right <= rectangleTwo.Right &&
            rectangleOne.Top <= rectangleTwo.Top &&
            rectangleOne.Bottom <= rectangleTwo.Bottom)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static Rectangle ReadPoints()
    {
        int[] coordinates = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Rectangle rectangle = new Rectangle();
        rectangle.Left = coordinates[0];
        rectangle.Top = coordinates[1];
        rectangle.Width = coordinates[2];
        rectangle.Height = coordinates[3];
        return rectangle;
    }
}