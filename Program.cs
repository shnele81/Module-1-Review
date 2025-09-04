namespace Module_1_Review;

class Program
{
    public static double CircleArea(double radius)
    {
        return  (radius * 2) * Math.PI;
    }

    public static double TriangleArea(double baseLength, double height)
    {
        return (baseLength * height) / 2;
    }

    public static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double SquareArea(double side)
    {
        return side * side;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of the circle is {CircleArea(radius)}");
        
        Console.WriteLine("Enter the base length of the triangle:");
        double baseLength = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the triangle");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of the triangle is {TriangleArea(baseLength, height)}");
        
        Console.WriteLine("Enter the length of the rectangle:");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of the rectangle is {RectangleArea(length, width)}");
        
        Console.WriteLine("Enter the length of the side of the square:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of the square is {SquareArea(side)}");
    }
}
