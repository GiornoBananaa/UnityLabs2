namespace Hotdogs
{
    public abstract class Hotdog
    {
        private readonly string _name;
        private readonly int _weight;
        private readonly int _cost;

        public Hotdog(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public string GetName() => _name;
        public int GetWeight() => _weight;
        public abstract int GetCost();
    }
}