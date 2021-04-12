using System;
using System.Collections.Generic;
using System.Text;

namespace task_3._3._3
{
    class Customer
    {
        public delegate void CustomerHandler(string message);
        public event CustomerHandler Notify;              // 1.Определение события

        public Pizzeria Dodo = new Pizzeria();

        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }

        public double totalPrice = 0;
        public int TotalPrice { get; private set; }

        public Dictionary<string, int> shoppingList = new Dictionary<string, int>();
        public void AddToOrder(int idPizza)
        {
            TotalPrice += Dodo.menu[idPizza].Price;
            if (shoppingList.ContainsKey(Dodo.menu[idPizza].Name))
            {
                shoppingList[Dodo.menu[idPizza].Name]++;
            }
            else
            {
                shoppingList.Add(Dodo.menu[idPizza].Name, 1);
            }

            Notify?.Invoke($"Товар: {Dodo.menu[idPizza].Name} добавлен в заказ, количество: {shoppingList[Dodo.menu[idPizza].Name]}, сумма заказа: {TotalPrice}");   // 2.Вызов события 
        }

        public void RemoveToOrder(int idPizza)
        {
            if (shoppingList.ContainsKey(Dodo.menu[idPizza].Name))
            {
                TotalPrice -= Dodo.menu[idPizza].Price;
                shoppingList.Remove(Dodo.menu[idPizza].Name);

                Notify?.Invoke($"Товар: {Dodo.menu[idPizza].Name} удален из заказа, сумма заказа: {TotalPrice}");   // 2.Вызов события 
            }
            else
            {
                Notify?.Invoke($"Товара: {Dodo.menu[idPizza].Name} нет в списке заказа, он не может быть удален.");
            }

        }

        public void PayOrder()
        {
            Notify?.Invoke($"Оплачено: {TotalPrice}.");
        }

        public void GetShoppingList()
        {
            foreach (var item in shoppingList)
            {
                Console.WriteLine(item);
            }
        }

        public void TakeOrder()
        {
            Notify?.Invoke($"Покупатель {Id} забрал заказ на кассе.");
        }
    }
}
