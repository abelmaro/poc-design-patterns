using PoC_Strategy.Context;
using PoC_Strategy.Strategy;

namespace PoC_Strategy
{
    public class Program
    {
        protected Program() { }
        public static void Main()
        {
            WalkBehavior walk = new WalkBehavior();
            FlyBehavior fly = new FlyBehavior();

            AnimalContext dog = new AnimalContext(walk);
            AnimalContext bird = new AnimalContext(fly);

            dog.DoBehavior();
            bird.DoBehavior();

        }
    }
}