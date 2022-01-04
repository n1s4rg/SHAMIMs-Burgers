using System;
using System.Collections.Generic;

namespace Project_Step_1
{
    public class Toppings
    {
        public static Dictionary<int, double> bpToppings = new Dictionary<int, double>(){
            {0, 0.5},
            {1, 0.5},
            {2, 0.5},
            {3, 1.5},
            {4, 0.5},
            {5, 0.5},
            {6, 0.5},
            {7, 0.5},
        };

        private List<int> toppingsAdded = new List<int>();

        public static List<string> toppings = new List<string>()
        { "Tomato" , "Cheese", "Onions","Chicken","Lettuce","Cucumber","Pickle","Carrots" };

        public List<int> ToppingsAdded { get => toppingsAdded; set => toppingsAdded = value; }

        public static void displayToppings()
        {
            foreach (KeyValuePair<int, double> tops in Toppings.bpToppings)
            {
                Console.WriteLine("{0}) {1} \t $ {2}", tops.Key + 1, toppings[tops.Key], tops.Value);
            }
        }

    }
}
