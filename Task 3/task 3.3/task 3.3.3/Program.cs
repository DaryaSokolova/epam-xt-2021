using System;

namespace task_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer acc = new Customer(123);
            acc.Notify += DisplayMessage;
            Pizzeria dodo = new Pizzeria();
            dodo.ProcessingPizza += DisplayMessage;
            dodo.IsReady += DisplayMessage;

            acc.AddToOrder(1);
            acc.AddToOrder(2);
            acc.AddToOrder(2);
            acc.RemoveToOrder(2);
            acc.RemoveToOrder(2);
            acc.PayOrder();

            dodo.Cooking();
            dodo.DisplayInfo(acc);

            acc.TakeOrder();

        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
