namespace Hotdogs
{
    public abstract class HotdogDecorator: Hotdog
    {
        protected Hotdog _hotdog;
        
        public HotdogDecorator(string name, int weight,Hotdog hotdog) : base(name,weight)
        {
            _hotdog = hotdog;
        }
    }
}