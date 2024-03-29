﻿namespace Application;

class Rectangle : Shape
{
    public int SideA { get; }
    public int SideB { get; }

    public int Area { get; }

    public Rectangle(int sideA, int sideB, Position position, Line line) : base(position, line)
    {
        SideA = sideA;
        SideB = sideB;
        Area = sideA * sideB;
        //Console.WriteLine("\n*Rectangle*:");
    }
}
