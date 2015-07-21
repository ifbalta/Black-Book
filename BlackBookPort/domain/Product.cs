using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBookPort
{
        /**
            Product Domain Object
         */
    class Product
    {
        private String id;
        private String name;
        private String description;
        private String category;
        private Double price;
        private int quantity;

        /** Product Properties*/
        public String ID {get { return id; } set {this.id = value;}
        }

        public String Name { get {return name;} set { this.name = value;}}

        public String Description { get { return description; } set { this.description = value; } }

        public String Category { get { return category; } set { this.category = value; } }

        public Double Price { get { return price; } set { this.price = value; } }

        public int Quantity { get { return quantity; } set { this.quantity = value; } }

        public override String ToString() {
            return String.Format("{0} {1}",id, name);
        }

    }
}
