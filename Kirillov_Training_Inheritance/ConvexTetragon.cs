namespace Kirillov_Training_Inheritance;

public class ConvexTetragon : Tetragon
{
    protected readonly float SideA;
    protected readonly float SideB;
    protected readonly float SideC;
    protected readonly float SideD;
    protected readonly float AngleAB;
    
    public ConvexTetragon(float sideA, float sideB, float sideC, float sideD, float angleAB)
    {
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        SideD = sideD;
        AngleAB = angleAB;
    }
    
    public override float CountPerimeter()
    {
        return SideA + SideB + SideC + SideD;
    }
    
    public override float CountArea()
    {
        float p = CountPerimeter() / 2;
        return MathF.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC)*(p-SideD));
    }
}