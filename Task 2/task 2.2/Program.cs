using System;

namespace task_2._2
{
    class Program
    {
        static int[,] collectingBonuses(int [,] arrBonus, Apple b1, Apple b2, Flower f1, Player player)
        {
            if (b1.bonusReceived(player.X, player.Y) == true && arrBonus[b1.X, b1.Y] == 1)
            {
                player.getApple();
                Console.WriteLine("Яблоко собрано!");
                arrBonus[b1.X, b1.Y] = 0;
            }

            if (b2.bonusReceived(player.X, player.Y) == true && arrBonus[b2.X, b2.Y] == 1)
            {
                player.getApple();
                Console.WriteLine("Яблоко собрано!");
                arrBonus[b2.X, b2.Y] = 0;
            }

            if (f1.bonusReceived(player.X, player.Y) == true && arrBonus[f1.X, f1.Y] == 1)
            {
                player.getFlower();
                Console.WriteLine("Вы нашли цветочек!");
                arrBonus[f1.X, f1.Y] = 0;
            }

            Console.WriteLine($"Здоровье: {player.Health}");
            Console.WriteLine($"Количество цветочков: {player.CountFlower}");

            return arrBonus;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Player I = new Player();

            Apple bon1 = new Apple(1, 1);
            Apple bon2 = new Apple(1, 2);
            Flower flo1 = new Flower(3, 4);

            int[,] arrBonus = new int[10, 10];

            arrBonus[bon1.X, bon1.Y] = 1;
            arrBonus[bon2.X, bon2.Y] = 1;
            arrBonus[flo1.X, flo1.Y] = 1;

            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(1, 0);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(0, 1);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(0, 1);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(0, -1);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");

            for (int i = 0; i < 20; i++)
            {
                char switchAction = Convert.ToChar(Console.ReadLine());
                switch (switchAction)
                {
                    case 'w':
                        I.Move(0, 1);
                        Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");

                        break;

                    case 'a':
                        I.Move(-1, 0);
                        Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");

                        break;

                    case 's':
                        I.Move(0, -1);
                        Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");

                        break;

                    case 'd':
                        I.Move(1, 0);
                        Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");

                        break;

                    default:

                        break;
                }

                arrBonus = collectingBonuses(arrBonus, bon1, bon2, flo1, I);
            }
        }
    }
}
