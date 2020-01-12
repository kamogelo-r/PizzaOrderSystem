using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderSystem
{
    class Pizza
    {
        private string toppings;
        private string crust;
        private double price;

        public string Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public string Crust
        {
            get { return crust; }
            set { crust = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Pizza()
        {

        }

        public Pizza(string toppings, string crust, double price)
        {
            this.toppings = toppings;
            this.crust = crust;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format(this.toppings +" "+ this.crust +" "+ this.price);
        }
        
    }
}
