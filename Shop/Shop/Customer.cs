using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Customer
    {
        private string _name;
        private string _address;
        private string _phone;

        public string Name { get { return _name; } }

        public Customer(string Name, string Address, string Phone)
        {
            _name = Name;
            _address = Address;
            _phone = Phone;
        }
    }
}
