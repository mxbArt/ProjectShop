using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        private string _name;
        private decimal _price;
        private int _count;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!value.Equals(""))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Invalid product name.The name of the product can't be an empty string");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price of a product has to be more then 0");
                }
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value >= 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Count of a product has to be more then 0");
                }
            }
        }

        public Product(string Name, decimal Price, int Count)
        {
            _name = Name;
            _price = Price;
            _count = Count;
        }
    }
}
