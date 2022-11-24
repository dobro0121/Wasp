using System;

namespace WASP
{
    internal class dz3
    {
        public void dz3_1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += Math.Pow(Convert.ToInt32(Console.ReadLine()), p);
            }
            result = Math.Pow(result, 1.0 / p);
            Console.WriteLine(result);
        }
        public void dz3_2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int min = _sort(mass)[k - 1]; // сортируем массив по возрастанию и берем k-тый элемент 
            Console.WriteLine("\n" + min);
        }
        private static int[] _sort(int[] mass) //сортировка вставками
        {
            int[] sortedmass = mass;
            for (int i = 0; i < sortedmass.Length - 1; i++)
            {
                for (int j = i + 1; j < sortedmass.Length; j++)
                {
                    if (sortedmass[j] < sortedmass[i])
                    { 
                        int temp = sortedmass[i];
                        sortedmass[i] = sortedmass[j];
                        sortedmass[j] = temp;
                    }
                }
            }
            return sortedmass;
        }
        public void dz3_3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            string[] format = Console.ReadLine().Split(':');
            int start = Convert.ToInt32(format[0]); // начало вывода
            int end = Convert.ToInt32(format[1]); // конец вывода
            int step = Convert.ToInt32(format[2]); // шаг вывода
            if (step < 0) // меняем местами начало и конец, если шаг < 0
            {
                int temp = start;
                start = end;
                end = temp;
            }
            for (int i = start; i != end + step; i += step)
            {
                Console.Write(mass[i] + " ");
                if ((end - i) * (end - i - step) < 0)
                {
                    break;
                }   
            }
        }
    }
}
