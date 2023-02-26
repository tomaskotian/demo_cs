namespace Application;

class Program
{
    static void Main(string[] args)
    {
        Circle obj1 = new Circle(5, new(2, 3), Color.Red) ;
        Console.WriteLine(obj1.Radius);
        Console.WriteLine(obj1.Area);
        Console.WriteLine(obj1.getPosition());
        Console.WriteLine(obj1.Color);

        Rectangle obj2 = new Rectangle(3, 5, Position.Default(), Color.Yellow);
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", obj2.SideA, obj2.SideB, obj2.Area, obj2.Color);
        Console.WriteLine(obj2.getPosition());
        
        Triangle obj3 = new Triangle(3, 9, new (20, 10), Color.Green);
        Console.WriteLine("Zakladna: {0}\nVyska: {1}\nPlocha: {2}\nFarba: {3}", obj3.BaseT, obj3.Height, obj3.Area, obj3.Color);
        Console.WriteLine("Suradnice: {0}", obj3.getPosition());

        

    }
    //main dopisanie kodu....
}