using System.Xml.Schema;

namespace Application;

struct Line
{
    public int LineWidth = 0;
    public Color color;


    public Line(int lineWidth, Color color)
    {
        LineWidth = lineWidth;
        this.color = color;
    }

    public static Line Default() => new Line(2,Color.Yellow);
}
