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

        public Product(String id, String name, String description, String category, Double price, int quantity ) 
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
        }

        public override String ToString() {
            return String.Format("id: {0}\nname:{1}\ndescription:{2}\nprice: {3}\nquantity:{4}\ncategory: {5}",
                id, name, description, price, quantity, category);
        }

    }
}
