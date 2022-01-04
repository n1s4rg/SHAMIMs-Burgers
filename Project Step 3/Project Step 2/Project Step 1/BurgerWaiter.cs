using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    class BurgerWaiter : Waiter
    {
		private BurgerBuilder burgerBuilder;

		public void setBurgerBuilder(BurgerBuilder burgerBuilder)
		{
			this.burgerBuilder = burgerBuilder;
		}

		public Burger getBurgerFromBuilder()
		{
			return this.burgerBuilder.GetBurger();
		}

		/*public void ConstructBurger()
		{
			burgerBuilder.createNewBurger();
			burgerBuilder.setNameForBurger();
			burgerBuilder.chooseBread();
			burgerBuilder.addMeat();
			burgerBuilder.addToppings();
			burgerBuilder.addExtras();
			burgerBuilder.calculatePrice();
		}*/

        public override void prepareOrder()
        {
			burgerBuilder.createNewBurger();
			burgerBuilder.setNameForBurger();
			burgerBuilder.chooseBread();
			burgerBuilder.addMeat();
			burgerBuilder.addToppings();
			burgerBuilder.addExtras();
			burgerBuilder.calculatePrice();
		}
    }
}
