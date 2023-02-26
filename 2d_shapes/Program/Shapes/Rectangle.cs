using System.Drawing;

namespace Application;

class Rectangle : Shape
{
    public int SideA { get; }
    public int SideB { get; }

    public long AreaRec { get; }

    public Rectangle(int sideA, int sideB, Position position) : base(position)
    {
        SideA = sideA;
        SideB = sideB;
        AreaRec = sideA * sideB;
        Console.WriteLine("\nRectangle:");
    }
}
