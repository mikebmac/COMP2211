/* 
 * The base class for Customer and Preferred Customer.
 * Course:  COMP 2211
 * Date:    July 18th, 2019
 * Author:  Michael MacKay
*/
using System;
namespace Assignment5 {
    public class Person {
        private string name;
        private string address;
        private string telephone;

        public Person(string name, string address, string telephone) {
            Name = name;
            Address = address;
            Telephone = telephone;
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Address {
            get {
                return address;
            }
            set {
                address = value;
            }
        }

        public string Telephone {
            get {
                return telephone;
            }
            set {
                telephone = value;
            }
        }

    }
}
