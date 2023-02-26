namespace Application;

class Program
{
    static void Main(string[] args)
    {
        Circle obj1 = new Circle(5, new (2, 3));
        Console.WriteLine(obj1.Radius);
        Console.WriteLine(obj1.Area);
        Console.WriteLine(obj1.getPosition());

        Rectangle obj2 = new Rectangle(3, 5, Position.Default());
        Console.WriteLine(obj2.SideA);
        Console.WriteLine(obj2.SideB);
        Console.WriteLine(obj2.AreaRec);
        Console.WriteLine(obj2.getPosition());
        

    }
    //main dopisanie kodu....
}