using PoC_Factory.Base;

namespace PoC_Factory.Creator
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod(decimal price);
        public abstract decimal GetPrice();
    }
}
