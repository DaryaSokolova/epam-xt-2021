using System;

namespace task_2._2
{
    class Program
    {
        static int[,] collectingBonuses(int [,] arrBonus, Bonus b1, Bonus b2, Player player)
        {
            if (b1.bonusReceived(player.X, player.Y) == true && arrBonus[b1.X, b1.Y] == 1)
            {
                player.getBonus();
                Console.WriteLine("Бонус собран!");
                arrBonus[b1.X, b1.Y] = 0;
            }

            if (b2.bonusReceived(player.X, player.Y) == true && arrBonus[b2.X, b2.Y] == 1)
            {
                player.getBonus();
                Console.WriteLine("Бонус собран!");
                arrBonus[b2.X, b2.Y] = 0;
            }

            Console.WriteLine($"Здоровье: {player.Health}");

            return arrBonus;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Player I = new Player();

            Bonus bon1 = new Bonus(1, 1);
            Bonus bon2 = new Bonus(1, 2);

            int[,] arrBonus = new int[3, 3];

            arrBonus[bon1.X, bon1.Y] = 1;
            arrBonus[bon2.X, bon2.Y] = 1;

            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(1, 0);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(0, 1);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(0, 1);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
            //I.Move(0, -1);
            //Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");

            for (int i = 0; i < 5; i++)
            {
                arrBonus = collectingBonuses(arrBonus, bon1, bon2, I);
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
            }
        }
    }
}
