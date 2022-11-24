using System;

namespace WASP
{
    internal class dz1
    {
        public void dz1_1()
        {
            for (int first = 3; first < 10; first++)
            {
                for (int second = 2; second < first; second++)
                {
                    for (int third = 1; third < second; third++)
                    {
                        for (int fourth = 0; fourth < third; fourth++)
                        {
                            Console.WriteLine(first * 1000 + second * 100 + third * 10 + fourth);
                        }
                    }
                }
            }
        }
        public void dz1_2()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int c = m; // число, которое выводится
            int u = 1; // задает первое число в каждой строке
            int t = 1; // для увеличения или уменьшения чисел
            bool flag = false; // флаг для смены знака переменной t
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(c + " ");
                    if (c == m) // если выполняется, то идем на уменьшение чисел
                    {
                        flag = true;
                        t -= 2;
                    }
                    c += t;
                }
                if (flag) // меняем знак t, чтобы опять начиналось с увеличения чисел
                {
                    t += 2;
                }
                c = m - u;
                u++;
                Console.WriteLine();
            }
        }
        public void dz1_3()
        {
            int x1, y1, x2, y2, x3, y3; // нумерация идёт с (0;0)
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            int otstupX = x1; // значения отступов от начала координат (0;0)
            int otstupY = y1;
            while(otstupY != 0) // кол-во отступов по оси OY
            {
                System.Console.WriteLine('!'); // ! - для видимости отступов по оси OY
                otstupY--;
            }
            for (int j = 1; j <= x3 - x1; j++)
            {
                for (int k = 0; k < otstupX; k++) // кол-во отступов по оси OX
                {
                    System.Console.Write('!');  // ! - для видимости отступов по оси OX
                }
                for (int l = 0; l < j; l++) // вывод звёздочек
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }
        }
        int factorial(int n)
        {
            int i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
        public void dz1_4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int c = 0; c <= i; c++)
                {
                    Console.Write(" "); // создаём пробелы между элементами треугольника Паскаля
                    Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника Паскаля
                }
                Console.WriteLine();
            }
        }

    }
}

