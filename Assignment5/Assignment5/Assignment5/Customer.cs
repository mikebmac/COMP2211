/* 
 * The class that stores the customer's information, derived off the Person class.
 * Course:  COMP 2211
 * Date:    July 18th, 2019
 * Author:  Michael MacKay
*/
using System;

namespace Assignment5 {
    public class Customer : Person {
        private int customerNum;
        private bool onMailList;

        public Customer(string name, string address, string telephone, int customerNum, bool onMailList)
            : base (name, address, telephone) {
            this.CustomerNum = customerNum;
            this.OnMailList = onMailList;
        }

        public int CustomerNum {
            get => customerNum;
            set => customerNum = value;
        }

        public bool OnMailList {
            get => onMailList;
            set => onMailList = value;
        }
    }
}
