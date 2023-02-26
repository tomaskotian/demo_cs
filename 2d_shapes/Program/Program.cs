﻿namespace Application;

class Program
{
    static void Main(string[] args)
    {
        Circle obj1 = new Circle(5, new(2, 3), Color.Red, Line.Default()) ;
        Console.WriteLine(obj1.Radius);
        Console.WriteLine(obj1.Area);
        Console.WriteLine(obj1.getPosition());
        Console.WriteLine(obj1.Color);
        Console.WriteLine(obj1.getLineWidth());

        Rectangle obj2 = new Rectangle(3, 5, Position.Default(), Color.Yellow, new(1));
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", obj2.SideA, obj2.SideB, obj2.Area, obj2.Color);
        Console.WriteLine(obj2.getPosition());
        Console.WriteLine(obj2.getLineWidth());
        
        Triangle obj3 = new Triangle(3, 9, new (20, 10), Color.Green, Line.Default());
        Console.WriteLine("Zakladna: {0}\nVyska: {1}", obj3.BaseT, obj3.Height);
        Console.WriteLine("Plocha: {0}\nFarba: {1}", obj3.Area, obj3.Color);
        Console.WriteLine("Suradnice: {0}", obj3.getPosition());
        Console.WriteLine(obj3.getLineWidth());
        

    }
    //main dopisanie kodu....
}