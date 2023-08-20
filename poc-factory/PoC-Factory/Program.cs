using PoC_Factory.Base;
using PoC_Factory.Creator.Concrete;
using C = PoC_Factory.Creator;

namespace PoC_Factory
{
    public class Program
    {
        protected Program() { }
        public static void Main()
        {
            List<C.Creator> creators = new List<C.Creator>
            {
                new NotebookCreator(1000),
                new NotebookCreator(2000),
                new NotebookCreator(4500),
                new KeyboardCreator(500)
            };

            foreach (C.Creator creator in creators)
            {
                decimal price = creator.GetPrice();
                Product product = creator.FactoryMethod(price);

                product.DisplayInfo();
            }
        }
    }
}