namespace Application;

class Shape
{
    public int Id { get; }
    public Position Position { get; }

    private static int _instanceCounter = 0;
    public Color Color { get; }
    public Line Line { get; }

    public Shape()
    {
        Id = ++_instanceCounter;

    }

    public Shape(Position position, Color color, Line line)
    {
        Id = ++_instanceCounter;

        Position = position;
        Color = color;
        Line = line;
    }

    public string getPosition()
    {
        return $"x = {Position.X} y = {Position.Y}";  
    }

    public string getLineWidth()
    {
        return $"Hrubka ciary = {Line.LineWidth}";
    }
}   //skuska shapes
