namespace Application;

class Shape
{
    public int Id { get; }
    public Position Position { get; }

    private static int _instanceCounter = 0;
    public Color Color { get; }

    public Shape()
    {
        Id = ++_instanceCounter;

    }

    public Shape(Position position, Color color)
    {
        Id = ++_instanceCounter;

        Position = position;
        Color = color;
    }

    public string getPosition()
    {
        return $"x = {Position.X} y = {Position.Y}";  
    }
}   //skuska shapes
