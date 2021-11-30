using System;

//Який принцип S.O.L.I.D. порушено? Виправте!
/**порушено принцип The Dependency Inversion Principle**/
interface IShape
{
    int Width { get; set; }
    int Height { get; set; }
    int GetArea();
}
class Rectangle : IShape
{
    private int width;
    private int height;
    public int Width { get => width; set => width = value; }
    public int Height { get => height; set => height = value; }
    public int GetArea()
    {
        return width * height;
    }
}
//квадрат наслідується від прямокутника!!!
class Square : IShape
{
    private int side;
    public int Width { get => side; set => side = value; }
    public int Height { get => side; set => side = value; }

    public int GetArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(rect.GetArea());
        Console.ReadKey();
    }
}
