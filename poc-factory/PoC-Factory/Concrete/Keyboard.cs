using PoC_Factory.Base;

namespace PoC_Factory.Concrete
{
    public class Keyboard : Product
    {
        public Keyboard(decimal price)
        {
            Price = price;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This keyboard costs: {Price}");
        }
    }
}
