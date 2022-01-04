using System.Collections.Generic;

namespace Project_Step_1
{
    public class Pizza
    {
        private string dough;
        private string sauce;
        private Toppings topping;
        private double basePrice = 5;
        private double totalPrice;
        private string name;
        private string breakout;

        public Pizza()
        {
            Dough = "Wheat";
            Sauce = "Tomato";
            Topping = new Toppings();
            this.TotalPrice = BasePrice;
            this.Name = "Basic Pizza";
        }

        public string Dough { get => dough; set => dough = value; }
        public string Sauce { get => sauce; set => sauce = value; }
        public Toppings Topping { get => topping; set => topping = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Name { get => name; set => name = value; }
        public string Breakout { get => breakout; set => breakout = value; }
        public double BasePrice { get => basePrice; }
    }

}
