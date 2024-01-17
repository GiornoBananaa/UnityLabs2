namespace Kirillov_Training_Inheritance;

public class Rhombus : Parallelogram
{
    public Rhombus(float a, float abAngle) : base(a, a, abAngle){}
    
    public override float CountPerimeter()
    {
        return SideA * 4;
    }
    
    public override float CountArea()
    {
        return SideA * SideA * MathF.Abs(MathF.Sin(AngleAB));
    }
}