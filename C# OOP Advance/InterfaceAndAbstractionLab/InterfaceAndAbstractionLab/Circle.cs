
using System;

public class Circle : IDrawable
{
    private int radius;
    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public int Radius {
        get { return this.radius; }
        private set { this.radius = value; } }

    public void Draw()
    {
        var rIn = this.Radius - 0.4;
        var rOut = this.Radius + 0.4;
        for (double i = this.Radius; i >= -this.Radius ; --i)
        {
            for (double j = -this.Radius; j < rOut; j += 0.5)
            {
                var value = i * i + j * j;

                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
