using System;

namespace Project_Step_1
{
    class VeggiePizzaBuilder : PizzaBuilder
    {
        public override void addDough()
        {
            //ask user
            pizza.Dough = "Flatbread";
        }

        public override void addSauce()
        {
            //ask user
            pizza.Sauce = "Mayo";
        }

        public override void addTopping()
        {
            Console.WriteLine("\nVeggie Pizza Toppings");
            Console.WriteLine("\nAdd any 3 toppings\n----------------------");
            Toppings.displayToppings();
            int toppingsLength = Toppings.toppings.Count;
            //only 2 toppings
            do
            {
                Console.Write("\nChoose a topping from above list ?: ");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose > 0 && choose <= toppingsLength)
                {
                    pizza.Topping.ToppingsAdded.Add(choose - 1);
                    Console.WriteLine("Topping added!");
                }
                else
                {
                    Console.WriteLine("Invalid topping selection!");
                }

            } while (true && pizza.Topping.ToppingsAdded.Count < 3);
        }

        public override void calculatePrice()
        {
            double sum = pizza.BasePrice;
            string temp = "\nName : " + pizza.Name + "\n----------------------\n";
            temp += "Base Price : $ " + pizza.BasePrice + "\n";
            temp += "Dough : " + pizza.Dough + "\n";
            temp += "Sauce : " + pizza.Sauce + "\n";
            temp += "Toppings\n";

            //toppings
            foreach (int elem in pizza.Topping.ToppingsAdded)
            {
                sum += Toppings.bpToppings[elem];
                temp += "  " + Toppings.toppings[elem] + "  \t  $ " + Toppings.bpToppings[elem] + "\n";
            }

            pizza.TotalPrice = sum;
            temp += "\nPrice ----------- $ " + pizza.TotalPrice;

            pizza.Breakout = temp;

            Console.WriteLine("\n===================================");
            Console.WriteLine(temp + "\n===================================");
        }

        public override void setName()
        {
            pizza.Name = "Veggie Pizza";
        }
    }
}
