namespace Application;

class Rectangle : Shape
{
    public int SideA { get; }
    public int SideB { get; }

    public int AreaRec { get; }

    public Rectangle(int sideA, int sideB, Position position) : base(position)
    {
        SideA = sideA;
        SideB = sideB;
        AreaRec = sideA * sideB;
        Console.WriteLine("\n*Rectangle*:");
    }
}
