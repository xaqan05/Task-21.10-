using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21._10_
{
    public abstract class Product
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void GetInfo();
    }
}
