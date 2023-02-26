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
        Console.WriteLine("{0}\n{1}\n{2}", obj2.SideA, obj2.SideB, obj2.AreaRec);
        Console.WriteLine(obj2.getPosition());
        
        Triangle obj3 = new Triangle(4, 5, new (20, 10));
        Console.WriteLine("Zakladna: {0}\nVyska: {1}\nPlocha: {2}", obj3.BaseT, obj3.Height, obj3.AreaTri);
        Console.WriteLine("Suradnice: {0}", obj3.getPosition());
    }
    //main dopisanie kodu....
}