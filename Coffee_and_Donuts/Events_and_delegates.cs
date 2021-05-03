using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_and_Donuts
{
    class Events_and_delegates
    {
        public delegate bool checkDoneDelegate();
        public delegate int addToOrderDelegate(int i);
        public int numDonutsOutstanding;
        public int numDonutsMade = 0;
        public bool isDonutsDone = false;
        public int numCoffeeOutstanding;
        public int numCoffeeMade = 0;
        public bool isCoffeeDone = false;
        public bool isDone = false;

        public void addDonuts(int i)
        {
            numDonutsOutstanding = i;
        }
        public void madeDonuts()
        {
            numDonutsMade++;
        }
        public void checkDonutsIsDone()
        {
            if (numDonutsMade >= numDonutsOutstanding)
            {
                isDonutsDone = true;
            }
        }
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
                isCoffeeDone = true;
            }
        }
        public void checkIsDone()
        {
            if((isCoffeeDone==true)&&(isDonutsDone==true))
            {
                isDone = true;
            }
        }
               
    }
}
