using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutsandCoffee
{
    class Barista
    { public void makeCoffee(Order o)
        {
            MessageBox.Show("Making Coffees : " + o.Coffee,"Barista");
            
        }
    }
}
