namespace Project_Step_1
{
    public class PizzaWaiter : Waiter
    {
        private PizzaBuilder pizzaBuilder;
        public void setPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }
        public Pizza getPizzaFromBuilder()
        {
            return this.pizzaBuilder.GetPizza();
        }

        /*public void ConstructPizza()
        {
            pizzaBuilder.createNewPizza();
            pizzaBuilder.setName();
            pizzaBuilder.addDough();
            pizzaBuilder.addSauce();
            pizzaBuilder.addTopping();
            pizzaBuilder.calculatePrice();
        }*/

        public override void prepareOrder()
        {
            pizzaBuilder.createNewPizza();
            pizzaBuilder.setName();
            pizzaBuilder.addDough();
            pizzaBuilder.addSauce();
            pizzaBuilder.addTopping();
            pizzaBuilder.calculatePrice();
        }
    }
}
