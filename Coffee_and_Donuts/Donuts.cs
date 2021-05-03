using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_and_Donuts
{
    class Donuts
    {
        public int numDonutsOutstanding;
        public int numDonutsMade = 0;
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
                isDone = true;
            }
        }
    }
}
