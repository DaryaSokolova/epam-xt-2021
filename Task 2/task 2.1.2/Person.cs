using System;
using System.Collections.Generic;
using System.Text;

namespace task_2._1._2
{
    class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        public Person(string name) 
        {
            Name = name;
        }
        public Person() { }

        public void writeName()
        {
            Console.WriteLine("Введите имя:");
            Name = Convert.ToString(Console.ReadLine());
        }
    }
}
