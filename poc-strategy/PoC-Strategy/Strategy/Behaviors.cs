using PoC_Strategy.Interfaces;

namespace PoC_Strategy.Strategy
{
    public class WalkBehavior : IBehavior
    {
        public void DoBehavior()
        {
            Console.WriteLine("The animal is walking");
        }
    }

    public class FlyBehavior : IBehavior
    {
        public void DoBehavior()
        {
            Console.WriteLine("The animal is flying");
        }
    }
}
