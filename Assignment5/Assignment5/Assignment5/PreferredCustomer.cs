using System;
using System.Collections.Generic;
using System.Linq;
/* 
 * Derived from the Customer Class, it applies discounts to future purchases based on spending.
 * Course:  COMP 2211
 * Date:    July 18th, 2019
 * Author:  Michael MacKay
*/
using System.Text;
using System.Threading.Tasks;

namespace Assignment5 {
    class PreferredCustomer : Customer {
        private double totalPurchases;

        public PreferredCustomer(string name, string address, string telephone, int customerNum, bool onMailList, double totalPurchases)
            : base (name, address, telephone, customerNum, onMailList) {
            TotalPurchases = totalPurchases;
        }

        public double TotalPurchases {
            get => totalPurchases;
            set => totalPurchases = value;
        }

        // Getter for the Discount based on total money spent
        public double Discount {
            get {
                if (TotalPurchases >= (double)2000) {
                    return 0.1;
                } else if (TotalPurchases >= (double)1500) {
                    return 0.07;
                } else if (TotalPurchases >= (double)1000) {
                    return 0.06;
                } else if (TotalPurchases >= (double)500) {
                    return 0.05;
                }
                return 0;
            }
        }
    }
}
