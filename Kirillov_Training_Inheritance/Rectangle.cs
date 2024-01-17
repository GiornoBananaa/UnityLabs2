namespace Kirillov_Training_Inheritance;

public class Rectangle : Parallelogram
{
    public Rectangle(float a, float b) : base(a, b, 90){}

    public override float CountArea()
    {
        return SideA*SideB;
    }
}