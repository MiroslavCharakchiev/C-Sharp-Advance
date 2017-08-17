
using System;

public class Rectangle : IDrawable
{
    private int widht;
    private int height;
    public Rectangle(int width, int height)
    {
        this.Widht = width;
        this.Height = height;
    }

    public int Widht
    {
        get { return this.widht; }
        private set { this.widht = value; }
    }

    public int Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }


    public void Draw()
    {
        DrawLine(this.Widht, '*', '*');
        for (int i = 1; i < this.Height -1; ++i)
        {
            DrawLine(this.Widht, '*', ' ');
        }
        DrawLine(this.Widht, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width -1 ; ++i)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}

