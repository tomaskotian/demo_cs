namespace Application;

class Circle : Shape
{
    const double pi = 3.14;
    public int Radius { get; }
    public double Area { get; }

    public Circle(int radius, Position position, Line line) : base(position, line)
    {
        Radius = radius;
        Area = Math.Round(radius * pi,2);
    }
}