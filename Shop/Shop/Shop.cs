using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Shop
    {
        public List<Product> items = new List<Product>();
        
        public void ShowAllProducts()
        {
            foreach (Product item in items)
            {
                Console.WriteLine(item.Name + " " + item.Price + " Count: " + item.Count);
            }
        }

        public Order Buy(string Name, Customer Customer)
        {
            Product purchase = items.FirstOrDefault(i => i.Name == Name);
            if (purchase == null)
            {
                Console.WriteLine("There are no such product on sale");
                return null;
            }
            else
            {
                if (purchase.Count > 0)
                {
                    items.FirstOrDefault(i => i.Name == Name).Count--;
                    return new Order(purchase, Customer, DateTime.Now);
                }
                else
                {
                    Console.WriteLine("There are no such product on sale now");
                    return null;
                }
            }
            
        }
    }
}
