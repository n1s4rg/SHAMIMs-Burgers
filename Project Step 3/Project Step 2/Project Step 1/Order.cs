using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Step_1
{
    public class Order
    {
        private int orderId;

        private List<Waiter> waiters = new List<Waiter>();

        private bool orderStatus;

        public List<Waiter> Waiters { get => waiters;}
        public int OrderId { get => orderId; set => orderId = value; }

        public void addWaiter(Waiter w)
        {
            Waiters.Add(w);
        }

        public bool getOrderStatus()
        {
            return this.orderStatus;
        }

        public void setOrderStatus(bool status)
        {
            this.orderStatus = status;

            foreach(Waiter waiter in Waiters)
            {
                waiter.prepareOrder();
            }
        }
    }
}
