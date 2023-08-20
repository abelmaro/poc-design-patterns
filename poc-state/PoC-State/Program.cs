using PoC_State.Context;

namespace PoC_State
{
    public class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.InsertCoin();
            vendingMachine.SelectDrink();
            vendingMachine.Dispense();
        }
    }

}