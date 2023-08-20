using PoC_State.Interfaces;

namespace PoC_State.States
{
    public class DispensingState : IState
    {
        public void InsertCoin()
            => Console.WriteLine("Can't insert coin while dispensing.");

        public void SelectDrink()
            => Console.WriteLine("Can't select another drink while dispensing.");

        public void Dispense()
            => Console.WriteLine("Dispensing drink...");
    }
}
