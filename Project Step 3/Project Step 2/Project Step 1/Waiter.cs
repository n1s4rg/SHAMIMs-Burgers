using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    public abstract class Waiter
    {
        public Order order;

        public abstract void prepareOrder();
    }
}
