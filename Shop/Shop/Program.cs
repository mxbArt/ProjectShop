using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.items.Add(new Product("Apple", 12, 2));
            shop.items.Add(new Product("Orange", 15, 1));
            shop.items.Add(new Product("Pear", 25, 10));
            shop.items.Add(new Product("Banana", 45, 5));

            shop.ShowAllProducts();
            Console.WriteLine();
            Order order = shop.Buy("Apple", new Customer("Maksim", "address", "1223456"));
            order.Print();
            try
            {
                order = shop.Buy("Table", new Customer("Maksim", "address", "1223456"));
                order.Print();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            shop.ShowAllProducts();
        }
    }
}
