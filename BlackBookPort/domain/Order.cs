using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBookPort.domain
{
    class Order
    {
        
        private String order_ID;
        private DateTime date;
        private List<OrderItem> order_items = new List<OrderItem>();

        public String OrderID { get { return order_ID; } set { this.order_ID = value; } }
        public DateTime Date { get { return date; } set { this.date = value; } }

        public Double getTotal() {
            double result = 0;
            foreach (OrderItem item in order_items) {
                result += item.getItemTotal();
            }
            return result;
        }

        public void addItem(OrderItem item) {
            order_items.Add(item);
        }
    }
}
