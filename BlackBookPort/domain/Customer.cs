using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBookPort.domain
{
    /** Customer Domain Object*/
    class Customer
    {
        private String userName;
        private String name;
        private String creditCardDetails;
        private String password;

        public String Username { get { return userName; } set { this.userName = value; } }
        public String Name { get { return name; } set { this.name = value; } }
        
        public void SetCreditCardDetails(String creditCardDetails) {
            this.creditCardDetails = creditCardDetails;
        }

        public void SetPassword(String password) {
            this.password = password;
        }


    }
}
