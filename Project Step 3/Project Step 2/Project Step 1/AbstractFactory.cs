using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    public abstract class AbstractFactory
    {
        private static VeggieFactory veggieFactory = new VeggieFactory();
        private static HawaiianFactory hawaiianFactory = new HawaiianFactory();

        public static AbstractFactory GetFactory(EnumChoice type)
        {
            AbstractFactory factory = null;

            if (type == EnumChoice.Veggie)
                factory = veggieFactory;
            else if (type == EnumChoice.Hawaiian)
                factory = hawaiianFactory;

            return factory;
        }

        public abstract void createBurger(Order o);
        public abstract void createPizza(Order o);
       
    }
}
