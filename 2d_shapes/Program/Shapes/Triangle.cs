namespace Application;

class Triangle : Shape
{
    public int BaseT { get; }
    public int Height { get; }
    public double Area { get; }

    public Triangle (int baseT, int height, Position position, Line line) : base(position, line)
    {
        BaseT = baseT;
        Height = height;
        Area = (baseT*height*0.5);
        //Console.WriteLine("\n*Triangle*:");
    }

}
