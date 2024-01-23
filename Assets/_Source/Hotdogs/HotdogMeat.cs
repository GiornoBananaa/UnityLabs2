namespace Hotdogs
{
    public class HotdogMeat : Hotdog
    {
        public HotdogMeat(string name, int weight) : base(name,weight) { }

        public override int GetCost()
        {
            return 290;
        }
    }
}