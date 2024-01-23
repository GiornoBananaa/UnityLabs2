namespace Hotdogs
{
    public class HotdogWithCucumber: HotdogDecorator
    {
        public HotdogWithCucumber(string name, int weight,Hotdog hotdog) : base(name, weight,hotdog) { }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 50;
        }
    }
}