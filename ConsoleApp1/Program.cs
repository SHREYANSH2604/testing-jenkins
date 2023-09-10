using System;

public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculateArea()
    {
        return Length * Width;
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("Rectangle Area Calculator");
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle { Length = length, Width = width };
        double area = rectangle.CalculateArea();

        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}
