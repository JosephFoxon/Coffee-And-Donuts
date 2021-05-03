using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_and_Donuts
{
    public partial class Form1 : Form
    {
        private Events_and_delegates worker = new Events_and_delegates();
        public Form1()
        {
            InitializeComponent();
            labelCoffeeReady.Hide();
            labelDonutReady.Hide();
            labelCompleteOrder.Hide();
        }

        private void textBoxNumCoffees_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.donutAdder(Int32.Parse(textBoxNumDonuts.Text));
            worker.coffeeAdder(Int32.Parse(textBoxNumCoffees.Text));
            labelCoffeeReady.Hide();
            labelDonutReady.Hide();
            labelCompleteOrder.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            worker.coffeeChecker();
            worker.donutChecker();
            worker.Checker();
            if(worker.IsDonutsDone==true)
            {
                labelDonutReady.Show();
                labelDonutsWaiting.Hide();
            }
            if(worker.IsCoffeeDone==true)
            {
                labelDonutReady.Show();
                labelDonutsWaiting.Hide();
            }
            if(worker.IsDone)
            {
                labelCompleteOrder.Show();
            }
        }

        private void buttonCoffee_Click(object sender, EventArgs e)
        {
            worker.madeCoffee();
        }

        private void buttonDonut_Click(object sender, EventArgs e)
        {
            worker.madeDonuts();
        }
    }
}
