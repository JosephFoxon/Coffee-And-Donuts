using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_and_Donuts
{
    class Coffee
    {
        public int numCoffeeOutstanding;
        public int numCoffeeMade = 0;
        public bool isDone = false;

        public void addCoffee(int i)
        {
            numCoffeeOutstanding = i;
        }
        public void madeCoffee()
        {
            numCoffeeMade++;
        }
        public void checkCoffeeIsDone()
        {
            if (numCoffeeMade >= numCoffeeOutstanding)
            {
                isDone = true;
            }
        }
    }
}
