namespace Application;

class Shape
{
    public int Id { get; set; }
    public Position Position { get; }

    private static int _instanceCounter = 0;
    public Line Line { get; }

    public Shape()
    {
        Id = _instanceCounter++;

    }

    public Shape(Position position, Line line)
    {
        Id = _instanceCounter++;

        Position = position;
        Line = line;
    }

    public string getPosition()
    {
        return $"x = {Position.X} y = {Position.Y}";  
    }

    public string getLine()
    {
        return $"Hrubka ciary = {Line.LineWidth}\nFarba ciary: {Line.color}\n";
    }
}   //skuska shapes
