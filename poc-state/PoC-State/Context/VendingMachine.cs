using PoC_State.Interfaces;
using PoC_State.States;

namespace PoC_State.Context {
    public class VendingMachine
    {
        private IState currentState;
        private int credit;
        private bool drinkSelected;

        public VendingMachine()
        {
            currentState = new NoCreditState();
            credit = 0;
            drinkSelected = false;
        }

        public void InsertCoin()
        {
            currentState.InsertCoin();
            credit += 1; 
            if (credit >= 1) 
                currentState = new HasCreditState();
        }

        public void SelectDrink()
        {
            currentState.SelectDrink();
            if (credit >= 1) 
            {
                drinkSelected = true;
                currentState = new DispensingState();
            }
        }

        public void Dispense()
        {
            currentState.Dispense();
            if (drinkSelected) 
            {
                drinkSelected = false;
                credit -= 2;
                currentState = new NoCreditState();
            }
        }
    }
}