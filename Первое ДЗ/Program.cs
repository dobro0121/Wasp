using System;

namespace WASP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dz1 dz_1 = new dz1();
            dz2 dz_2 = new dz2();
            dz3 dz_3 = new dz3();
            Console.WriteLine("Выберете номер задачи от 1 до 10, которую хотите посмотреть в работе, либо 0 - выход из программы: ");
            int key = Convert.ToInt32(Console.ReadLine());
            while (key != 0)
            {
                switch (key)
                {
                    case 1:
                        dz_1.dz1_1(); // Волшебные числа*
                        break;
                    case 2:
                        dz_1.dz1_2(); // Дальше - меньше - засчитано
                        break;
                    case 3:
                        dz_1.dz1_3(); // Рисование треугольника*
                        break;
                    case 4:
                        dz_1.dz1_4(); // Треугольник Паскаля - засчитано
                        break;
                    case 5:
                        dz_2.dz2_1(); // Двоичная система
                        break;
                    case 6:
                        dz_2.dz2_2(); // Сложение в столбик*
                        break;
                    case 7:
                        dz_2.dz2_3(); // Упаковка шортиков*
                        break;
                    case 8:
                        dz_3.dz3_1(); // Норма вектора*
                        break;
                    case 9:
                        dz_3.dz3_2(); // k-тый минимум*
                        break;
                    case 10:
                        dz_3.dz3_3(); // Умный вывод массива*
                        break;
                }
                Console.WriteLine("Выберете номер задачи от 1 до 10,либо 0 - выход из программы: ");
                key = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
        
    }
}
