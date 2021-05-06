using System;
using System.Collections.Generic;
using System.Text;

namespace DonutsandCoffee
{   //Code Attribution
    //Author : VC SOIT
    //https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_kfOd8KRx93r92u5UYyzdQ_w&index=6
    class ProcessOrder
    {   
        public delegate void ProcessOrderDelegate(Order o);
        public event ProcessOrderDelegate OrderSubmitted;

        public void ProcessTheOrder(Order o)
        {  
            Barista b = new Barista();
            Donuteer d = new Donuteer();
            PaymentService ps = new PaymentService();
           
            OrderSubmitted+=b.makeCoffee;
            OrderSubmitted += d .packDonuts;
            OrderSubmitted += ps.collectPayment;

            OnOrderSubmitted(o);
        }
        protected virtual void OnOrderSubmitted(Order o)
        {

            if (OrderSubmitted != null)
            {
                OrderSubmitted(o);
            }
        }
    }
}
