using PoC_State.Interfaces;

namespace PoC_State.States
{
    public class NoCreditState : IState
    {
        public void Dispense()
            => Console.WriteLine("Insert credit first.");
        public void InsertCoin()
            => Console.WriteLine("Credit added.");
        public void SelectDrink()
            => Console.WriteLine("Insert credit first.");
    }
}
