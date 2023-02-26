namespace Application;

class Rectangle : Shape
{
    public int SideA { get; }
    public int SideB { get; }

    public int Area { get; }

    public Rectangle(int sideA, int sideB, Position position, Color color) : base(position, color)
    {
        SideA = sideA;
        SideB = sideB;
        Area = sideA * sideB;
        Console.WriteLine("\n*Rectangle*:");
    }
}
