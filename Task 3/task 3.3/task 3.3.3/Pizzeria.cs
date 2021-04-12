using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task_3._3._3
{
    class Pizzeria
    {
        public delegate void PizzeriaHandler(string message);
        public event PizzeriaHandler ProcessingPizza;              // 1.Определение события
        public event PizzeriaHandler IsReady;              // 1.Определение события
        public Pizzeria() { }

        public Dictionary<int, Pizza> menu = new Dictionary<int, Pizza>()
        {
            {1, new Pizza(450, "Мексиканская") },
            {2, new Pizza(550, "Гавайская") },
            {3, new Pizza(346, "Веганская") },
            {4, new Pizza(666, "Пицца для Викентия") }
        };

        public void WriteMenu()
        {
            foreach (var item in menu)
            {
                Console.WriteLine(item.Key + " " + item.Value.Price + " " + item.Value.Name);
            }
        }

        public void Cooking()
        {
            ProcessingPizza?.Invoke($"Ресторан готовит пиццу.");
        }

        public void DisplayInfo(Customer person)
        {
            IsReady?.Invoke($"{person.Id} может забрать заказ.");
        }
    }
}
