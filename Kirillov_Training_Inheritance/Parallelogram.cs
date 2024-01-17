namespace Kirillov_Training_Inheritance;

public class Parallelogram : ConvexTetragon
{
    public Parallelogram(float a, float b, float abAngle) : base(a, b, a, b, abAngle){}
    
    public override float CountPerimeter()
    {
        return (SideA+SideB)*2;
    }
    
    public override float CountArea()
    {
        return SideA*SideB*MathF.Abs(MathF.Sin(AngleAB));
    }
}