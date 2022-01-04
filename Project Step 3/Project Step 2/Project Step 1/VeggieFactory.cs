namespace Project_Step_1
{
    public class VeggieFactory : AbstractFactory
    {
        private static PizzaWaiter pizzaWaiter = new PizzaWaiter();
        private static BurgerWaiter burgerWaiter = new BurgerWaiter();

        public override void createBurger(Order order)
        {
            BurgerBuilder veggieBurgerBuilder = new VeggieBurgerBuilder();
            burgerWaiter.setBurgerBuilder(veggieBurgerBuilder);

            order.addWaiter(burgerWaiter);
            //burgerWaiter.ConstructBurger();

            //return burgerWaiter.getBurgerFromBuilder();
        }

        public override void createPizza(Order order)
        {
            PizzaBuilder VeggiePizzaBuilder = new VeggiePizzaBuilder();
            pizzaWaiter.setPizzaBuilder(VeggiePizzaBuilder);
            
            order.addWaiter(pizzaWaiter);
            //pizzaWaiter.ConstructPizza();

            //return pizzaWaiter.getPizzaFromBuilder();
        }
    }
}
