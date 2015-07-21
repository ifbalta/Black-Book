using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBookPort.domain
{
    class OrderItem
    {
        private int quantityPurchased;
        private double purchasePrice;

        public int QuantityPurchased { get { return this.quantityPurchased; } set { this.quantityPurchased = value; } }
        public double PurchasePrice { get { return this.purchasePrice; } set { this.purchasePrice = value; } }

        public double getItemTotal() {
            return quantityPurchased * purchasePrice;
        }
    }
}
