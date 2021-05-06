using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutsandCoffee
{
    class Donuteer
    {
        public void packDonuts(Order o)
        {
            MessageBox.Show("Packing Donuts : " + o.Donuts,"Donuteer");
        }
    }
}
