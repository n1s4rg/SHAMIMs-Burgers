using System;

namespace Project_Step_1
{
    public class HawaiianBurgerBuilder : BurgerBuilder
    {
        public override void chooseBread()
        {
            //ask user
            burger.BreadType = "White";
        }

        public override void addMeat()
        {
            //ask user
            burger.MeatType = "Chicken";
        }

        public override void addToppings()
        {
            //ask user
            Console.WriteLine("\nHawaiian Burger Toppings");
            Console.WriteLine("\nAdd any 4 toppings\n----------------------");
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

            sum += 3; //chips price

            burger.TotalPrice = sum;

            temp += "  Chips and Drink" + "  $ 3 \n";
            temp += "\nPrice ----------- $ " + burger.TotalPrice;

            burger.Breakout = temp;
            Console.WriteLine("\n===================================");
            Console.WriteLine(temp + "\n===================================");
        }

        public override void setNameForBurger()
        {
            burger.Name = "Hawaiian Burger";
        }

    }
}
