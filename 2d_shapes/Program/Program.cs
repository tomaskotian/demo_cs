namespace Application;

class Program
{
    static void Main(string[] args)
    {
        Position position_ob1 = new Position(5, 3);
        Shape ob1 = new Shape(position_ob1);
        Console.WriteLine(ob1.Id);
        Console.WriteLine(ob1.Id);
        Console.WriteLine(ob1.getPosition());

        Shape ob2 = new Shape();
        Console.WriteLine(ob2.Id);
        Console.WriteLine(ob2.getPosition());

        const int x = 5;
        const int ygit  = 5;
    }
}