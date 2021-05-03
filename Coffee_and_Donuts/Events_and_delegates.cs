using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_and_Donuts
{
    class Events_and_delegates
    {
        public delegate bool checkDoneDelegate();
        public delegate int addToOrderDelegate(int i);

        public void delegateWorker()
        {
            addToOrderDelegate adder = new addToOrderDelegate()
        }
       
    }
}
