namespace Application;

class Shape
{
    public int Id { get; set; }
    public Position Position { get; }

    private static int _instanceCounter = 0;

    public Shape()
    {
        Id = _instanceCounter++;

    }

    public Shape(Position position)
    {
        Id = _instanceCounter++;

        Position = position;
    }

    public string getPosition()
    {
        return $"x = {Position.X} y = {Position.Y}";  
    }
}   //skuska shapes
