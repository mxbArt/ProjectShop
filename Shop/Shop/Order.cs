using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Order
    {
        private Product _product;
        private DateTime _oredrDate;
        private Customer _customer;
        
        public Order(Product Prod, Customer Cust, DateTime Date)
        {
            _product = Prod;
            _customer = Cust;
            _oredrDate = Date;
        }

        public void Print()
        {
            Console.WriteLine("Customer: {0}, Product: {1}, Date: {2}", _customer.Name, _product.Name, _oredrDate);
        }
    }
}
