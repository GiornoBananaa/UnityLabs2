namespace Hotdogs
{
    public class HotdogCesar : Hotdog
    {
        public HotdogCesar(string name, int weight) : base(name,weight) { }

        public override int GetCost()
        {
            return 290;
        }
    }
}