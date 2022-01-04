using System;

/*
    Team members
`````````````````````````````````````````
    Abhiroop Singh Abhiroop Singh
    Danish Danish
    Nisarg Kumar Ashokbhai Prajapati
    Deep ParkashKumar Vagehla
    Syed, Samiuddin
    Waghmare, Abhijeet Shekhar
 
 */
namespace Project_Step_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory;
            Console.WriteLine("\tShamim's Burger and Pizza Place\n****************************************************");

            Order order = new Order();
            
            int choice = -1;
            do
            {
                try
                {
                    Console.WriteLine("\n\tWhat do you want?\n--------------------------------------\n(1) Burger\n(2) Pizza\n(9) CHECKOUT");
                    Console.Write("\nChoose ?: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    string type = "";
                  

                    if (choice == 1)
                    {
                        do
                        {
                            //burger
                            Console.WriteLine("\n   Burger Type\n------------------- \n(v) Veggie Burger\n(h) Hawaiian Burger\n(X) <<< Back to MAIN Menu");
                            Console.Write("\nChoose ?: ");
                            type = Console.ReadLine();

                            if (type == "v" || type == "V")
                            {
                                factory = AbstractFactory.GetFactory(EnumChoice.Veggie);
                                factory.createBurger(order);
                                Console.WriteLine("\nVeggie Burger added to the order!");
                                //totalBill += burger.TotalPrice;
                                //totalBreakout += burger.Breakout;
                            }
                            else if (type == "H" || type == "h")
                            {
                                factory = AbstractFactory.GetFactory(EnumChoice.Hawaiian);
                                factory.createBurger(order);
                                Console.WriteLine("\nHawaiian Burger added to the order!");
                                //totalBill += burger.TotalPrice;
                                //totalBreakout += burger.Breakout;
                            }
                            else if (type == "X" || type == "x")
                                break;
                            else
                                Console.WriteLine("> Invalid Burger choice <");


                        } while (type != "X" || type != "x");

                    }
                    else if (choice == 2)
                    {
                        do
                        {
                            //pizza
                            Console.WriteLine("\n    Pizza Type\n------------------- \n(v) Veggie Pizza\n(h) Hawaiian Pizza\n(X) <<< Back to MAIN Menu");
                            Console.Write("\nChoose ?: ");
                            type = Console.ReadLine();
                            if (type == "v" || type == "V")
                            {
                                factory = AbstractFactory.GetFactory(EnumChoice.Veggie);
                                factory.createPizza(order);
                                Console.WriteLine("\nVeggie Pizza added to the order!");
                                //totalBill += pizza.TotalPrice;
                                //totalBreakout += pizza.Breakout;
                            }
                            else if (type == "H" || type == "h")
                            {
                                factory = AbstractFactory.GetFactory(EnumChoice.Hawaiian);
                                factory.createPizza(order);
                                Console.WriteLine("\nHawaiian Pizza added to the order!");
                                //totalBill += pizza.TotalPrice;
                                //totalBreakout += pizza.Breakout;
                            }
                            else if (type == "X" || type == "x")
                                break;
                            else
                                Console.WriteLine("> Invalid Pizza choice <");
                        } while (type != "X" || type != "x");

                    }
                    else if (choice == 9)
                    {
                        order.setOrderStatus(true);
                        break;
                    }
                    else
                        Console.WriteLine("> Invalid choice <");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                }

            } while (choice != 9);


            if(order.Waiters.Count > 0)
            {
                Random rnd = new Random();
                int orderNum = rnd.Next(100, 1000);
                Console.WriteLine("\nOrder number: "+ orderNum);
                Console.WriteLine("\nThank you!");
                order.OrderId = orderNum;
            } else
            {
                Console.WriteLine("Goodbye...");

            }
            
            Console.ReadLine();
        }
    }
}
