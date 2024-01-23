using UnityEngine;
//"Хот-дог Классический"
//"Хот-дог Цезарь"
//"Хот-дог Мясной"
//" с маринованными огурцами"
//" с сладким луком"
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

    public class HotdogClassic : Hotdog
    {
        public HotdogClassic(string name, int weight) : base(name, weight) { }

        public override int GetCost()
        {
            return 210;
        }
    }
    
    public class HotdogCesar : Hotdog
    {
        public HotdogCesar(string name, int weight) : base(name,weight) { }

        public override int GetCost()
        {
            return 290;
        }
    }
    
    public class HotdogMeat : Hotdog
    {
        public HotdogMeat(string name, int weight) : base(name,weight) { }

        public override int GetCost()
        {
            return 290;
        }
    }
    
    public abstract class HotdogDecorator: Hotdog
    {
        protected Hotdog _hotdog;
        
        public HotdogDecorator(string name, int weight,Hotdog hotdog) : base(name,weight)
        {
            _hotdog = hotdog;
        }
    }
    
    public class HotdogWithCucumber: HotdogDecorator
    {
        public HotdogWithCucumber(string name, int weight,Hotdog hotdog) : base(name, weight,hotdog) { }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 50;
        }
    }
    
    public class HotdogWithOnion: HotdogDecorator
    {
        public HotdogWithOnion(string name, int weight, Hotdog hotdog) : base(name, weight,hotdog) { }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 30;
        }
    }
}