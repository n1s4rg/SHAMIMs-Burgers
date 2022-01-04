namespace Project_Step_1
{
    public abstract class PizzaBuilder
    {
        public Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void createNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void addDough();
        public abstract void addSauce();
        public abstract void addTopping();

        public abstract void setName();
        public abstract void calculatePrice();
    }
}
