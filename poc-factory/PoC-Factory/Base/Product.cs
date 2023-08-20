namespace PoC_Factory.Base
{
    public abstract class Product
    {
        public required decimal Price { get; set; }
        public virtual void DisplayInfo() {
            Console.WriteLine("Base Product");
        }
    }
}
