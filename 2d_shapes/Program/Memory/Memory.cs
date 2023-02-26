
namespace Application;
class Memory : IGui
{
    public Shape[] arrShapes { get; }
    private static int LastIndex = 0; 
    public Memory()
    {
    arrShapes = new Shape[100];
    }

    public void addShape(Shape shape)
    {
        arrShapes[LastIndex] = shape;
        LastIndex++;
    }

    public void removeShape(int id)
    {
        for (int indx = 0;indx < LastIndex; indx++)
        {
            if (id >= indx)
            {
                arrShapes[indx] = arrShapes[indx + 1];
            }
        }
        arrShapes[LastIndex-1] = null;

    }

    
    public void printShapes()
    {
        foreach(Shape shape in arrShapes)
        {
            if (shape == null)
            {
                continue;
            }
            Console.WriteLine($"{shape.GetType()} {shape.Id}");
        }
    }

}
