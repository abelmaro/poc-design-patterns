﻿using PoC_Factory.Base;
using PoC_Factory.Concrete;

namespace PoC_Factory.Creator.Concrete
{
    public class KeyboardCreator : Creator
    {
        private readonly decimal _price;
        public KeyboardCreator(decimal price)
        {
            _price= price;
        }

        public override Product FactoryMethod(decimal price)
        {
            return new Keyboard(price)
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
