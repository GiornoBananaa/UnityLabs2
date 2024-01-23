namespace Hotdogs
{
    public class HotdogWithOnion: HotdogDecorator
    {
        public HotdogWithOnion(string name, int weight, Hotdog hotdog) : base(name, weight,hotdog) { }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 30;
        }
    }
}