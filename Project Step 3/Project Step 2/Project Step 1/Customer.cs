using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    class Customer
    {
        private List<Order> listOfOrders;

        public List<Order> ListOfOrders { get => listOfOrders; set => listOfOrders = value; }
    }
}
