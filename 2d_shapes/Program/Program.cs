namespace Application;

class Program
{
    static void Main(string[] args)
    {
        Circle obj1 = new Circle(5, new(2, 3), Line.Default()) ;
        Console.WriteLine(obj1.Radius);
        Console.WriteLine(obj1.Area);
        Console.WriteLine(obj1.getPosition());
        Console.WriteLine(obj1.getLine());
        
        Rectangle obj2 = new Rectangle(3, 5, Position.Default(), new(1, Color.Red));
        Console.WriteLine("{0}\n{1}\n{2}", obj2.SideA, obj2.SideB, obj2.Area);
        Console.WriteLine(obj2.getPosition());
        Console.WriteLine(obj2.getLine());
        
        Triangle obj3 = new Triangle(3, 9, new (20, 10), Line.Default());
        Console.WriteLine("Zakladna: {0}\nVyska: {1}", obj3.BaseT, obj3.Height);
        Console.WriteLine("Plocha: {0}", obj3.Area);
        Console.WriteLine("Suradnice: {0}", obj3.getPosition());
        Console.WriteLine(obj3.getLine());

        Memory CreatedShapes = new Memory(); 

        if (Console.ReadKey(true).Key == ConsoleKey.A)
        {
            CreatedShapes.addShape(new Circle(5, new (2,3), new (1, Color.Red)));
            CreatedShapes.addShape(new Rectangle(3,4, new(2, 3), new(1, Color.Blue)));
            CreatedShapes.addShape(new Circle(5, new(2, 3), new(1, Color.Green)));
        }

        CreatedShapes.printShapes();
        CreatedShapes.removeShape(1);
        Console.WriteLine("//////////////////");
        CreatedShapes.printShapes();
       

    }
    //main dopisanie kodu....
}