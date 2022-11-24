using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class dz2
    {
        public void dz2_1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string number = _convert(n);
            Console.WriteLine(n + " -> " + number);
        }
        public void dz2_2()
        {
            int first, second, result;
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            result = first + second; // сумма обоих чисел
            string firstStr = _convert(first), secondStr = _convert(second), resultStr = _convert(result);
            int len = resultStr.Length; // длина суммы
            while (firstStr.Length < len) firstStr = "0" + firstStr; // добавление незначащих нулей слева для первого числа
            while (secondStr.Length < len) secondStr = "0" + secondStr; // добавление незначащих нулей слева для второго числа
            Console.WriteLine(firstStr + '\n' + secondStr + "\n\n" + resultStr);
        }
        private static string _convert(int a) // конвертация в двоичную СС
        {
            string number = "";
            uint n = (uint)a;
            int count = (int)(Math.Log(n, 2)) + 1;
            while (count > 0)
            {
                number += ((n << 31 - --count) >> 31).ToString();
            }
            return number;
        }
        public void dz2_3()
        {
            short first = Convert.ToInt16(Console.ReadLine());
            short second = Convert.ToInt16(Console.ReadLine());
            short third = Convert.ToInt16(Console.ReadLine());
            short fourth = Convert.ToInt16(Console.ReadLine());
            long result = 0;
            long maska = fourth;
            maska <<= 48;
            result |= maska;
            maska = third;
            maska <<= 32;
            result |= maska;
            maska = second;
            maska <<= 16;
            result |= maska;
            maska = first;
            result |= maska;
            Console.WriteLine(result);
        }
    }
}
