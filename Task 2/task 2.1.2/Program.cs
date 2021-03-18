using System;

namespace task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] countFigures = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            string[] arrCircle = new string[10];
            string[] arrCircleWithout = new string[10];
            string[] arrRing = new string[10];
            string[] arrRect = new string[10];
            string[] arrQua = new string[10];
            string[] arrTri = new string[10];
            string[] arrLin = new string[10];

            Person per = new Person();
            per.writeName();

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"{per.Name}, выберите действие:");
                Console.WriteLine("1 - добавить фигуру");
                Console.WriteLine("2 - вывести все фигуры");
                Console.WriteLine("3 - очистить поле");
                Console.WriteLine("4 - сменить пользователя");

                int switchAction = 0;

                try
                {
                    switchAction = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");

                }

                switch (switchAction)
                {
                    case 1:
                        for (int i = 0; i < 2; i++)
                        {

                            Console.WriteLine("№ figure");

                            int switchFigure = 0;

                            try
                            {
                                switchFigure = Int32.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");

                            }

                            switch (switchFigure)
                            {
                                case 1:

                                    Circle cir = new Circle();

                                    try
                                    {
                                        cir.Enter();

                                        arrCircle[countFigures[1]] = cir.GetInfo();
                                        countFigures[1]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                case 2:

                                    CircleWithoutArea cirWithout = new CircleWithoutArea();

                                    try
                                    {
                                        cirWithout.Enter();

                                        arrCircleWithout[countFigures[2]] = cirWithout.GetInfo();
                                        countFigures[2]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                case 3:

                                    Ring rin = new Ring();

                                    try
                                    {
                                        rin.Enter();

                                        arrRing[countFigures[3]] = rin.GetInfo();
                                        countFigures[3]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                case 4:

                                    Rectangle rec = new Rectangle();

                                    try
                                    {
                                        rec.Enter();

                                        arrRect[countFigures[4]] = rec.GetInfo();
                                        countFigures[4]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                case 5:

                                    Quadrate qua = new Quadrate();

                                    try
                                    {

                                        qua.Enter();

                                        arrQua[countFigures[5]] = qua.GetInfo();
                                        countFigures[5]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                case 6:

                                    Triangle tri = new Triangle();

                                    try
                                    {
                                        tri.Enter();

                                        arrTri[countFigures[6]] = tri.GetInfo();
                                        countFigures[6]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                case 7:

                                    Line lin = new Line();

                                    try
                                    {
                                        lin.Enter();

                                        arrLin[countFigures[7]] = lin.GetInfo();
                                        countFigures[7]++;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Ошибка: {ex.Message}");

                                    }

                                    break;

                                default:
                                    break;
                            }
                        }
                        break;

                    case 2:

                        if (countFigures[1] != 0)
                        {
                            for (int i = 0; i < countFigures[1]; i++)
                            {
                                Console.WriteLine(arrCircle[i]);
                            }
                        }

                        if (countFigures[2] != 0)
                        {
                            for (int i = 0; i < countFigures[2]; i++)
                            {
                                Console.WriteLine(arrCircleWithout[i]);
                            }
                        }

                        if (countFigures[3] != 0)
                        {
                            for (int i = 0; i < countFigures[3]; i++)
                            {
                                Console.WriteLine(arrRing[i]);
                            }
                        }

                        if (countFigures[4] != 0)
                        {
                            for (int i = 0; i < countFigures[4]; i++)
                            {
                                Console.WriteLine(arrRect[i]);
                            }
                        }

                        if (countFigures[5] != 0)
                        {
                            for (int i = 0; i < countFigures[5]; i++)
                            {
                                Console.WriteLine(arrQua[i]);
                            }
                        }

                        if (countFigures[6] != 0)
                        {
                            for (int i = 0; i < countFigures[6]; i++)
                            {
                                Console.WriteLine(arrTri[i]);
                            }
                        }

                        if (countFigures[7] != 0)
                        {
                            for (int i = 0; i < countFigures[7]; i++)
                            {
                                Console.WriteLine(arrLin[i]);
                            }
                        }

                        break;

                    case 3:

                        if (countFigures[1] != 0)
                        {
                            for (int i = 0; i < countFigures[1]; i++)
                            {
                                arrCircle[i] = "";
                            }
                            countFigures[1] = 0;
                        }

                        if (countFigures[2] != 0)
                        {
                            for (int i = 0; i < countFigures[2]; i++)
                            {
                                arrCircleWithout[i] = "";
                            }
                            countFigures[2] = 0;
                        }

                        if (countFigures[3] != 0)
                        {
                            for (int i = 0; i < countFigures[3]; i++)
                            {
                                arrRing[i] = "";
                            }
                            countFigures[3] = 0;
                        }

                        if (countFigures[4] != 0)
                        {
                            for (int i = 0; i < countFigures[4]; i++)
                            {
                                arrRect[i] = "";
                            }
                            countFigures[4] = 0;
                        }

                        if (countFigures[5] != 0)
                        {
                            for (int i = 0; i < countFigures[5]; i++)
                            {
                                arrQua[i] = "";
                            }
                            countFigures[5] = 0;
                        }

                        if (countFigures[6] != 0)
                        {
                            for (int i = 0; i < countFigures[6]; i++)
                            {
                                arrTri[i] = "";
                            }
                            countFigures[6] = 0;
                        }

                        if (countFigures[7] != 0)
                        {
                            for (int i = 0; i < countFigures[7]; i++)
                            {
                                arrLin[i] = "";
                            }
                            countFigures[7] = 0;
                        }

                        break;

                    case 4:

                        per.writeName();

                        break;

                    default:
                        Console.WriteLine("Вы вышли");
                        break;
                }
            }

        }
    }
}
