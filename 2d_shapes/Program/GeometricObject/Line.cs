namespace Application;

struct Line
{
    public int LineWidth = 0;

    public Line(int lineWidth)
    {
        LineWidth = lineWidth;
    }

    public static Line Default() => new Line(2);

}
