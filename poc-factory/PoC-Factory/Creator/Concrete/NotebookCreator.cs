using PoC_Factory.Base;
using PoC_Factory.Concrete;

namespace PoC_Factory.Creator.Concrete
{
    internal class NotebookCreator : Creator
    {
        private readonly decimal _price;

        public NotebookCreator(decimal price) {
            _price = price;
        }
        public override Product FactoryMethod(decimal price)
        {

            return new Notebook()
            {
                Price = _price
            };
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}
