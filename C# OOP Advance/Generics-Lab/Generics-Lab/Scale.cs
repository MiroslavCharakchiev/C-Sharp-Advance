using System;

public class Scale<T>
    where T : IComparable
{
    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public T Left { get; }
    public T Right { get; }

    public T GetHavier()
    {
        var res = this.Left.CompareTo(this.Right);
        if (res < 0)
        {
            return this.Right;
        }
        if (res > 0)
        {
            return this.Left;
        }
        return default(T);
    }
}