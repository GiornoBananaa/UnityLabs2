namespace Kirillov_Training_Inheritance;

public static class Program
{
    public static void Main()
    {
        Tetragon[] tetragons =
        {
            new ConvexTetragon(3,6,2,7,50),
            new Parallelogram(8,14,70),
            new Rectangle(10,5),
            new Rhombus(6,80),
            new Square(2)
        };

        foreach (var tetragon in tetragons)
        {
            Console.WriteLine(tetragon.CountPerimeter());
            Console.WriteLine(tetragon.CountArea());
            Console.WriteLine();
        }
    }
}