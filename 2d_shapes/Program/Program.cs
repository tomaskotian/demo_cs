namespace Application;

class Program
{
    static void Main(string[] args)
    {
        Circle obj1 = new Circle(5, new (2, 3));
        Console.WriteLine(obj1.Radius);
        Console.WriteLine(obj1.Area);
        Console.WriteLine(obj1.getPosition());

    }
}