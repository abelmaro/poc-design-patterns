using PoC_Factory.Base;

namespace PoC_Factory.Concrete
{
    public class Notebook : Product
    {
        //public Notebook(decimal price)
        //{
        //    Price = price;
        //}
        public override void DisplayInfo()
        {
            Console.WriteLine($"This Notebook costs: {Price}");
        }
    }
}
