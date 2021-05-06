using System;
using System.Collections.Generic;
using System.Text;

namespace DonutsandCoffee
{
    class Order
    {
        string name;
        int donuts;
        int coffee;

        public Order(string name, int donuts, int coffee)
        {
            this.name = name;
            this.donuts = donuts;
            this.coffee = coffee;
        }

        public string Name { get => name; set => name = value; }
        public int Donuts { get => donuts; set => donuts = value; }
        public int Coffee { get => coffee; set => coffee = value; }
    }
}
