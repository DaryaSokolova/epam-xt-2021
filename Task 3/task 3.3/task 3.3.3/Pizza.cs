using System;
using System.Collections.Generic;
using System.Text;

namespace task_3._3._3
{
    public class Pizza
    {
        public Pizza(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public int Price
        {
            get;
        }

        public string Name
        {
            get;
        }
    }
}
