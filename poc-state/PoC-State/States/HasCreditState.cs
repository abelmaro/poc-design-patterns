using PoC_State.Interfaces;

namespace PoC_State.States
{
    public class HasCreditState : IState
    {
        public void Dispense()
            => Console.WriteLine("A drink was dispensed.");
        public void InsertCoin()
            => Console.WriteLine("Another coin was inserted.");
        public void SelectDrink()
            => Console.WriteLine("A drink was selected.");
    }
}
