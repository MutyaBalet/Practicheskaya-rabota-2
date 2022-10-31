int prog;
do
{
    Console.WriteLine("Выберите программу:\n1) Угадай число, \n2) Таблица умножения\n3) " +
        "Вывод делителей числа\nВведите '0', чтобы завершить работу программы. ");
    prog = int.Parse(Console.ReadLine());
    switch (prog)
    {
        case 1:
            Random y = new Random();
            int random = y.Next(0, 100);
            do
            {
                int num;
                Console.WriteLine("Угадай число от 0 до 100");
                num = int.Parse(Console.ReadLine());
                if (num == random)
                {
                    Console.WriteLine("Ты угадал число!");
                    prog = 2;
                    break;
                }
                else if (num > random)
                {
                    while (num > random)
                    {
                        Console.WriteLine("Введи число меньше");
                        num = int.Parse(Console.ReadLine());
                        if (num < random)
                        {
                            while (num < random)
                            {
                                Console.WriteLine("Введи число больше");
                                num = int.Parse(Console.ReadLine());
                                if (num < random)
                                {
                                    continue;
                                }
                                else if (num == random)
                                {
                                    Console.WriteLine("Ты угадал число!");
                                    prog = 2;
                                    break;
                                }
                            }
                        }
                        else if (num > random)
                        {
                            continue;
                        }
                    }
                }
                else if (num < random)
                {
                    while (num < random)
                    {
                        Console.WriteLine("Введи число больше");
                        num = int.Parse(Console.ReadLine());
                        if (num > random)
                        {
                            while (num > random)
                            {
                                Console.WriteLine("Введи число меньше");
                                num = int.Parse(Console.ReadLine());
                                if (num < random)
                                {
                                    continue;
                                }
                                else if (num == random)
                                {
                                    Console.WriteLine("Ты угадал число!");
                                    prog = 2;
                                    break;
                                }
                            }
                        }
                        else if (num == random)
                        {
                            Console.WriteLine("Ты угадал число!");
                            prog = 2;
                            break;
                        }
                        else if (num < random)
                        {
                            continue;
                        }
                    }
                }
            } while (prog == 1);
            break;
        case 2:
            Console.WriteLine("\n");
            int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int num2 = 0; num2 < num1.Length; num2++)
            {
                Console.Write($"  {num1[0] * num1[num2]}\t  " +
                    $"{num1[1] * num1[num2]}\t  " +
                    $"{num1[2] * num1[num2]}\t  " +
                    $"{num1[3] * num1[num2]}\t  " +
                    $"{num1[4] * num1[num2]}\t  " +
                    $"{num1[5] * num1[num2]}\t  " +
                    $"{num1[6] * num1[num2]}\t  " +
                    $"{num1[7] * num1[num2]}\t  " +
                    $"{num1[8] * num1[num2]}\t\n");
            }
            Console.WriteLine("\n");
            break;
        case 3:
            int num3;
            do
            {
                Console.WriteLine("Введите число для вывода его делителей\nЧтобы выйти введите '0'");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                for (int i = 1; i <= num3; i++)
                {
                    int result;
                    result = num3 % i;
                    if (result == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }
                Console.WriteLine("\n");
            }
            while (num3 != 0);
            break;
        case 0:
            break;
    }
} while (prog != 0);