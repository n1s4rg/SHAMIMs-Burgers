using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    public class Burger
    {
        private string breadType;
        private string meatType;
        private Toppings toppings;
        private Toppings extras;
        private double basePrice = 2;
        private double totalPrice;
        private string name;
        private string breakout;

        public Burger()
        {
            this.Name = "Basic Burger";
            this.BreadType = "";
            this.MeatType = "";
            this.Topping = new Toppings();
            this.Extras = new Toppings();
            this.TotalPrice = BasePrice;
        }

        public string BreadType { get => breadType; set => breadType = value; }
        public string MeatType { get => meatType; set => meatType = value; }
        public Toppings Topping { get => toppings; set => toppings = value; }
        public Toppings Extras { get => extras; set => extras = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public double BasePrice { get => basePrice; }
        public string Name { get => name; set => name = value; }
        public string Breakout { get => breakout; set => breakout = value; }
    }
}
