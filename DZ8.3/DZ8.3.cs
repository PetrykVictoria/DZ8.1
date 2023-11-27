using System;

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        get { return base.Height; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }

    // налаштування розмірів квадрата
    public void SetSideLength(int sideLength)
    {
        Width = sideLength;
        Height = sideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine(rect.GetRectangleArea());

        Square square = new Square();
        square.SetSideLength(5);
        Console.WriteLine(square.GetRectangleArea());

        Console.ReadKey();
    }
}
