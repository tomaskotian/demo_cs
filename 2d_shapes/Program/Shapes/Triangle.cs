namespace Application;

class Triangle : Shape
{
    public int BaseT { get; }
    public int Height { get; }
    public double AreaTri { get; }

    public Triangle (int baseT, int height, Position position) : base(position)
    {
        BaseT = baseT;
        Height = height;
        AreaTri = Math.Round(baseT*height*0.5);
        Console.WriteLine("\n*Triangle*:");
    }

}
