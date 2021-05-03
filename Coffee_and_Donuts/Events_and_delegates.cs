using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_and_Donuts
{
    class Events_and_delegates
    {
        public delegate void checkDoneDelegate();
        public delegate void addToOrderDelegate(int i);
        private int numDonutsOutstanding;
        private int numDonutsMade = 0;
        private bool isDonutsDone = false;
        private int numCoffeeOutstanding;
        private int numCoffeeMade = 0;
        private bool isCoffeeDone = false;
        private bool isDone = false;

        public int NumDonutsOutstanding { get => numDonutsOutstanding; set => numDonutsOutstanding = value; }
        public int NumDonutsMade { get => numDonutsMade; set => numDonutsMade = value; }
        public bool IsDonutsDone { get => isDonutsDone; set => isDonutsDone = value; }
        public int NumCoffeeOutstanding { get => numCoffeeOutstanding; set => numCoffeeOutstanding = value; }
        public int NumCoffeeMade { get => numCoffeeMade; set => numCoffeeMade = value; }
        public bool IsCoffeeDone { get => isCoffeeDone; set => isCoffeeDone = value; }
        public bool IsDone { get => isDone; set => isDone = value; }

        event addToOrderDelegate orderEvent;
        event checkDoneDelegate checkDone;

        public void addDonuts(int i)
        {
            NumDonutsOutstanding = i;
        }
        public void madeDonuts()
        {
            NumDonutsMade++;
        }
        public void checkDonutsIsDone()
        {
            if (NumDonutsMade >= NumDonutsOutstanding)
            {
                IsDonutsDone = true;
            }
        }
        public void addCoffee(int i)
        {
            NumCoffeeOutstanding = i;
        }
        public void madeCoffee()
        {
            NumCoffeeMade++;
        }
        public void checkCoffeeIsDone()
        {
            if (NumCoffeeMade >= NumCoffeeOutstanding)
            {
                IsCoffeeDone = true;
            }
        }
        public void checkIsDone()
        {
            if((IsCoffeeDone==true)&&(IsDonutsDone==true))
            {
                IsDone = true;
            }
        }
        public void coffeeAdder(int i)
        {
            this.orderEvent += new addToOrderDelegate(addCoffee);            
        }
        public void donutAdder(int i)
        {
            this.orderEvent += new addToOrderDelegate(addDonuts);            
        }
        
        
        public void coffeeChecker()
        {
            this.checkDone += new checkDoneDelegate(checkCoffeeIsDone);
        }
        public void donutChecker()
        {
            this.checkDone += new checkDoneDelegate(checkDonutsIsDone);
        }
        public void Checker()
        {
            this.checkDone += new checkDoneDelegate(checkIsDone);
        }
    }
}
