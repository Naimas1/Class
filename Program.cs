using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void Open()
        {
            Console.WriteLine("Магазин {0} відкритий.", Name);
        }

        public void Close()
        {
            Console.WriteLine("Магазин {0} закритий.", Name);
        }

        public void Dispose()
        {
            Close();
        }
    }

    enum ShopType
    {
        Grocery,
        Household,
        Clothing,
        Shoes
    }

    class Programs
    {
        static void Main(string[] args)
        {
            using (Shop shop = new Shop("Моя продуктова", "вул. Продуктова, 123", ShopType.Grocery))
            {
                shop.Open();
            }

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
