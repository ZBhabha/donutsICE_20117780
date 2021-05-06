using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutsandCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Picture on form taken from :
       //https://www.google.com/url?sa=i&url=https%3A%2F%2Fwallpaperaccess.com%2Fcoffee-and-donut&psig=AOvVaw0dw51zEwYc_GPetmXCl867&ust=1620324805713000&source=images&cd=vfe&ved=2ahUKEwi5gf-0krPwAhUDQhoKHZuUA_AQr4kDegUIARCxAg
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int donuts = Convert.ToInt32(nuDonuts.Value);
            int coffee = Convert.ToInt32(nuCoffee.Value);
            Order o = new Order(name, donuts, coffee);
            ProcessOrder p = new ProcessOrder();
            p.ProcessTheOrder(o);
           

        }
    }
}
