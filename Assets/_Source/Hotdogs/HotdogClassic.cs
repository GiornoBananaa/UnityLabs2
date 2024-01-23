namespace Hotdogs
{
    public class HotdogClassic : Hotdog
    {
        public HotdogClassic(string name, int weight) : base(name, weight) { }

        public override int GetCost()
        {
            return 210;
        }
    }
}