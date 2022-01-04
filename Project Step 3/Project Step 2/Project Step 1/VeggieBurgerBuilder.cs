using System;

namespace Project_Step_1
{
    public class VeggieBurgerBuilder : BurgerBuilder
    {

        public override void chooseBread()
        {
            burger.BreadType = "Brown";
        }

        public override void addMeat()
        {
            burger.MeatType = "VegPatty";
        }

        public override void addToppings()
        {
            Console.WriteLine("\nVeggie Burger Toppings");
            Console.WriteLine("\nSelect any 4 toppings\n----------------------");
            Toppings.displayToppings();
            int toppingsLength = Toppings.toppings.Count;
            //only 4 toppings
            do
            {
                Console.Write("\nChoose a topping from above list ?: ");
                int choose = Convert.ToInt32(Console.ReadLine());



                if (choose > 0 && choose <= toppingsLength)
                {
                    burger.Topping.ToppingsAdded.Add(choose - 1);
                    Console.WriteLine("Topping added!");
                }
                else
                {
                    Console.WriteLine("Invalid topping selection!");
                }

            } while (true && burger.Topping.ToppingsAdded.Count < 4);


        }

        public override void addExtras()
        {
            //ask user
            Console.WriteLine("\nExtra toppings");
            Console.WriteLine("\nAdd any 2 toppings\n----------------------");
            Toppings.displayToppings();
            int toppingsLength = Toppings.toppings.Count;
            //only 2 toppings
            do
            {
                Console.Write("\nChoose a topping from above list ?: ");
                int choose = Convert.ToInt32(Console.ReadLine());


                if (choose > 0 && choose <= toppingsLength)
                {
                    burger.Extras.ToppingsAdded.Add(choose - 1);
                    Console.WriteLine("Topping added!");
                }
                else
                {
                    Console.WriteLine("Invalid topping selection!");
                }

            } while (true && burger.Extras.ToppingsAdded.Count < 2);
        }

        public override void calculatePrice()
        {
            double sum = burger.BasePrice;
            string temp = "\nName : " + burger.Name + "\n----------------------\n";
            temp += "Base Price : $ " + burger.BasePrice + "\n";
            temp += "Bread Type : " + burger.BreadType + "\n";
            temp += "Meat Type : " + burger.MeatType + "\n";
            temp += "Toppings\n";

            //toppings
            foreach (int elem in burger.Topping.ToppingsAdded)
            {
                sum += Toppings.bpToppings[elem];
                temp += "  " + Toppings.toppings[elem] + "  \t  $ " + Toppings.bpToppings[elem] + "\n";
            }
            temp += "Extras\n";

            //extras
            foreach (int elem in burger.Extras.ToppingsAdded)
            {
                sum += Toppings.bpToppings[elem];
                temp += "  " + Toppings.toppings[elem] + "  \t  $ " + Toppings.bpToppings[elem] + "\n";
            }


            burger.TotalPrice = sum;
            temp += "\nPrice ----------- $ " + burger.TotalPrice;
            burger.Breakout = temp;

            Console.WriteLine("\n===================================");
            Console.WriteLine(temp + "\n===================================");
        }

        public override void setNameForBurger()
        {
            burger.Name = "Veggie Burger";
        }

    }
}
