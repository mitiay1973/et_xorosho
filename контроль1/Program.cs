using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace контроль1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Выберите задание");
            int var = Convert.ToInt32(Console.ReadLine());
            switch (var)
            {
                case 1:
                    program.one();
                    break;
                case 2:
                    program.two();
                    break;
                case 3:
                   program.three();
                    break;
                case 4:
                    program.four();
                    break;
                case 5:
                   program.five();
                    break;
                case 6:
                   program.six();
                    break;
                case 7:
                    program.seven();
                    break;
                case 8:
                    program.eit();
            break; 
            }
            Console.ReadKey();
        }
        public void one()
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Pow(a, b);
            Console.WriteLine("Ответ: " + c);
        }
        public void two()
        {
            Console.WriteLine("Формула не найдена, выберите другую задачу");
        }
        public void three()
        {
            Console.WriteLine("Введите число");
            double q = Convert.ToDouble(Console.ReadLine());
            double otvet = q % 2;
            double otvet1 = q % 3;
            if (otvet == otvet1)
            {
                Console.WriteLine("Одинаковый остаток = " + otvet);
            }
            else
            {
                Console.WriteLine("Остатки различаются");
            }
        }
        public void four()
        {
            Console.WriteLine("Введите число");
            int t = Convert.ToInt32(Console.ReadLine());
            int otv;
            Console.WriteLine("Результат:");
            for (int n = 1; n <= 10; n++)
            {
                otv = Convert.ToInt32(Math.Pow(t, n));
                Console.WriteLine(otv);
            }
        }
        public void five()
        {
            Console.WriteLine("Введите X");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double otv1 = (1 + Math.Sin(Math.Sqrt(x1 + 1))) / (Math.Cos((12 * y1) - 4));
            Console.WriteLine("Ответ: " + otv1);
        }
        public void six()
        {
            Console.WriteLine("Введите количество чисел");
            int f = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int s1 = 1;
            Console.WriteLine("Числа Фибоначчи");
            Console.WriteLine("1 индекс 2");
            for (int i = 2; i < f * 2; i++)
            {
                s = s + s1;
                if (i % 2 != 0)
                {
                    int ind = i + 1;
                    Console.WriteLine(s + " индекс " + ind);
                }
            }
        }
        public void seven()
        {
            Console.WriteLine("Введите количество чисел");
            int f1 = Convert.ToInt32(Console.ReadLine());
            double res = 0;
            double m = 1;
            double v = 2;
            for (int i = 0; i < f1; i++)
            {
                res += m / v;
                m++;
                v++;
            }
            Console.WriteLine("Результат: " + res);
        }
        public void eit()
        {
            int ind1;
            int[] sec = new int[3];
            int yc = 0;
            int secl = 0;
            for (int i = 0; i < 3; i++) // for
            {
                ind1 = i + 1;
                Console.WriteLine("Время " + ind1 + " спортсмена\n Введите секунды");
                sec[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++) // for
            {
                if (i == 0)
                {
                    secl = sec[i];
                    yc = i + 1;
                }
                if (i != 0)
                {
                    if (secl > sec[i])
                    {
                        secl = sec[i];
                        yc = i + 1;
                    }
                }
            }
            Console.WriteLine("Победил плавец под номером " + yc + " его время " + secl + " сек");
        }
    }
}
