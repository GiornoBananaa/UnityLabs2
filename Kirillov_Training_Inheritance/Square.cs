namespace Kirillov_Training_Inheritance;

public class Square : Rhombus
{
    public Square(float a) : base(a, 90){}

    public override float CountArea()
    {
        return SideA*SideA;
    }
}