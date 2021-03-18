using System;

namespace task_2._2
{
    class Program
    {
        static int[,] collectingBonuses(int[,] arrBonus, Apple b1, Apple b2, Flower f1, Player player)
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

            return arrBonus;
        }

        static void moveOfWolfs(Wolf wolf, Player I, Obstacle obs1, Obstacle obs2)
        {
            Random rnd = new Random();
            int valueForSwitch = rnd.Next(0, 3);

            switch (valueForSwitch)
            {
                case 0:
                    try
                    {

                        wolf.Move(0, 1, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Волк: {ex.Message}");

                    }

                    break;

                case 1:
                    try
                    {

                        wolf.Move(-1, 0, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Волк: {ex.Message}");

                    }

                    break;

                case 2:
                    try
                    {

                        wolf.Move(0, -1, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Волк: {ex.Message}");

                    }

                    break;

                case 3:
                    try
                    {

                        wolf.Move(1, 0, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Волк: {ex.Message}");

                    }

                    break;

                default:

                    break;
            }

            if (wolf.meetWithPlayer(I) == true)
            {
                I.getHurt();
            }
        }

        static void moveOfTrolls(Troll troll, Player I, Obstacle obs1, Obstacle obs2)
        {
            Random rnd = new Random();
            int valueForSwitch = rnd.Next(0, 3);

            switch (valueForSwitch)
            {
                case 0:
                    try
                    {

                        troll.Move(0, 1, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Тролль: {ex.Message}");

                    }

                    break;

                case 1:
                    try
                    {

                        troll.Move(1, 0, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Тролль: {ex.Message}");

                    }

                    break;

                case 2:
                    try
                    {

                        troll.Move(0, -1, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Тролль: {ex.Message}");

                    }

                    break;

                case 3:
                    try
                    {

                        troll.Move(-1, 0, obs1, obs2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Тролль: {ex.Message}");

                    }

                    break;

                default:

                    break;
            }

            if (troll.meetWithPlayer(I) == true)
            {
                I.getHurt();
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Player I = new Player();

            Apple bon1 = new Apple(1, 1);
            Apple bon2 = new Apple(1, 2);
            Flower flo1 = new Flower(3, 4);


            Wolf wolf1 = new Wolf(5, 5);
            Wolf wolf2 = new Wolf(9, 9);
            Troll troll1 = new Troll(3, 6);

            Obstacle obs1 = new Obstacle(4, 4);
            Obstacle obs2 = new Obstacle(5, 6);

            int[,] arrBonus = new int[10, 10];

            arrBonus[bon1.X, bon1.Y] = 1;
            arrBonus[bon2.X, bon2.Y] = 1;
            arrBonus[flo1.X, flo1.Y] = 1;

            int countBonus = 3;

            while ((countBonus != 0) && (I.Health > 0))
            {
                string str = Console.ReadLine();
                char switchAction = '0';

                try
                {
                    switchAction = Char.Parse(str);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Что-то не так: {ex.Message}");

                }

                switch (switchAction)
                {
                    case 's':
                        try
                        {
                            I.Move(0, 1, obs1, obs2);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Персонаж: {ex.Message}");

                        }

                        break;

                    case 'a':
                        try
                        {

                            I.Move(-1, 0, obs1, obs2);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Персонаж: {ex.Message}");

                        }

                        break;

                    case 'w':
                        try
                        {

                            I.Move(0, -1, obs1, obs2);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Персонаж: {ex.Message}");

                        }

                        break;

                    case 'd':
                        try
                        {

                            I.Move(1, 0, obs1, obs2);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Персонаж: {ex.Message}");

                        }

                        break;

                    default:

                        break;
                }

                arrBonus = collectingBonuses(arrBonus, bon1, bon2, flo1, I);
                moveOfWolfs(wolf1, I, obs1, obs2);
                moveOfWolfs(wolf2, I, obs1, obs2);
                moveOfTrolls(troll1, I, obs1, obs2);

                int countBonus1 = 0;
                for (int i1 = 0; i1 < 10; i1++)
                {
                    for (int i2 = 0; i2 < 10; i2++)
                    {
                        if (arrBonus[i1, i2] == 1)
                        {
                            countBonus1++;
                        }
                    }
                }

                countBonus = countBonus1;

                Console.WriteLine($"Здоровье: {I.Health}");
                Console.WriteLine($"Количество цветочков: {I.CountFlower}");
                Console.WriteLine($"Координаты игрока: {I.X}, {I.Y}.");
                Console.WriteLine($"Координаты волков: {wolf1.X}, {wolf1.Y} и {wolf2.X}, {wolf2.Y}");
                Console.WriteLine($"Координаты тролля: {troll1.X}, {troll1.Y}");
                Console.WriteLine($"Бонусов осталось: {countBonus}");


                char[,] arrField = new char[15, 15];
                for (int j1 = 0; j1 < 15; j1++)
                {
                    for (int j2 = 0; j2 < 15; j2++)
                    {
                        arrField[j1, j2] = ' ';
                    }
                }

                if (arrBonus[bon1.X, bon1.Y] == 1)
                {
                    arrField[bon1.X, bon1.Y] = '^';

                }

                if (arrBonus[bon2.X, bon2.Y] == 1)
                {
                    arrField[bon2.X, bon2.Y] = '^';
                }

                if (arrBonus[flo1.X, flo1.Y] == 1)
                {
                    arrField[flo1.X, flo1.Y] = '^';
                }

                arrField[wolf1.X, wolf1.Y] = '&';
                arrField[wolf2.X, wolf2.Y] = '&';

                arrField[troll1.X, troll1.Y] = '&';

                arrField[obs1.X, obs1.Y] = '@';
                arrField[obs2.X, obs2.Y] = '@';

                arrField[I.X, I.Y] = '*';

                for (int j2 = 0; j2 < 15; j2++)
                {
                    for (int j1 = 0; j1 < 15; j1++)
                    {
                        Console.Write(arrField[j1, j2]);
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Игра окончена!");
        }
    }
}
