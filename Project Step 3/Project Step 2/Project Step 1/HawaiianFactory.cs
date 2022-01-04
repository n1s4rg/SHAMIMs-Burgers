using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    public class HawaiianFactory : AbstractFactory
    {
        private static PizzaWaiter pizzaWaiter = new PizzaWaiter();
        private static BurgerWaiter burgerWaiter = new BurgerWaiter();

        public override void createBurger(Order order)
        {
            BurgerBuilder HawaiianBurgerBuilder = new HawaiianBurgerBuilder();
            burgerWaiter.setBurgerBuilder(HawaiianBurgerBuilder);
            
            order.addWaiter(burgerWaiter);
            //burgerWaiter.ConstructBurger();

            //return burgerWaiter.getBurgerFromBuilder();
        }

        public override void createPizza(Order order)
        {
            PizzaBuilder HawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            pizzaWaiter.setPizzaBuilder(HawaiianPizzaBuilder);

            order.addWaiter(pizzaWaiter);
            //pizzaWaiter.ConstructPizza();

            //return pizzaWaiter.getPizzaFromBuilder();
        }
    }
}
