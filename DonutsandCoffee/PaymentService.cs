using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutsandCoffee
{
    class PaymentService
    { // prices for coffee and donuts
        int donutPrice = 10;
        int coffeePrice = 15;
        public void collectPayment(Order o)
        {   // code to work out the total cost of the order
            double total = (donutPrice * o.Donuts) + (coffeePrice * o.Coffee);
            MessageBox.Show("Collecting Payment From : " + o.Name+"\nYour total is : R"+total,"Payment");
        }

    }
}
