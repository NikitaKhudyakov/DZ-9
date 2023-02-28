bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задания :");

    int.TryParse(Console.ReadLine(), out int w);
    {
        switch (w)
        {
            case 1:
                {
                    int m = ReadInt("число");
                    int ReadInt(string arg)
                    {
                        int number = 0;
                        Console.Write($"Введите {arg}: ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Попробуйте ещё раз! ");
                        }

                        return number;
                    }

                    string PrintNumb(int m)
                    {
                        if (m > 0) return $"{m} " + PrintNumb(m - 1);
                        else return String.Empty;

                    }
                    System.Console.WriteLine(PrintNumb(m));

                    break;
                }
            case 2:
                {



                    int m = ReadInt("первое число");
                    int n = ReadInt("второе число");
                    int ReadInt(string arg)
                    {
                        int number = 0;
                        Console.Write($"Введите {arg}: ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Попробуйте ещё раз! ");
                        }

                        return number;
                    }

                    int NumbSum(int m, int n)
                    {
                        int sum = 0;
                        if (m <= n) return sum += m + NumbSum(m + 1, n);
                        return 0;

                    }
                    System.Console.WriteLine(NumbSum(m, n));

                    break;
                }
            case 3:
                {

                    int n = ReadInt("первое число");
                    int m = ReadInt("второе число");
                    int ReadInt(string arg)
                    {
                        int number = 0;
                        Console.Write($"Введите {arg}: ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Попробуйте ещё раз! ");
                        }

                        return number;
                    }

                    int Akkerman(int n, int m)
                    {

                        if (n == 0)
                        {
                            return m + 1;
                        }
                        else if (n != 0 && m == 0)
                        {
                            return Akkerman(n - 1, 1);
                        }
                        if (n > 0 && m > 0)
                        {
                            return Akkerman(n - 1, Akkerman(n, m - 1));
                        }

                        return Akkerman(n, m);

                    }
                    System.Console.WriteLine(Akkerman(n, m));
                    break;
                }

            case -1: isWork = false; break;
        }

    }
}


