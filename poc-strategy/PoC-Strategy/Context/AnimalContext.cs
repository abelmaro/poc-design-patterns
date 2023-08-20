using PoC_Strategy.Interfaces;

namespace PoC_Strategy.Context
{
    public class AnimalContext
    {
        private readonly IBehavior _behavior;

        public AnimalContext(IBehavior behavior) { 
            _behavior = behavior;
        }

        public void DoBehavior()
        {
            _behavior.DoBehavior();
        }
    }
}
