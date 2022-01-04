namespace Project_Step_1
{
    public abstract class BurgerBuilder
    {
        public Burger burger;

        public Burger GetBurger()
        {
            return burger;
        }

        public void createNewBurger()
        {
            burger = new Burger();
        }


        public abstract void chooseBread();

        public abstract void addMeat();

        public abstract void addToppings();

        public abstract void addExtras();

        public abstract void setNameForBurger();
        public abstract void calculatePrice();
    }
}
