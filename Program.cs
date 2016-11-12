using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТП1
{
    class Program
    {
        static void Main(string[] args)
        {//red
            int Xk, Yk, Xc, Yc, i, p = 0;
            Random rnd = new Random();
            Xk = rnd.Next(3, 7);
            Yk = rnd.Next(-4, 2);
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Введите коорлинаты X и У");
                string test = Console.ReadLine();
                string[] splitString = test.Split(' ');
                int[] ints = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    int x;
                    int.TryParse(splitString[j], out x);
                    ints[j] = x;
                }
                Xc = ints[0];
                Yc = ints[1];


                if (Xc == Xk && Yc == Yk)
                {

                    Console.WriteLine("ПОПАДАНИЕ!");
                    p++;
                    break;
                }
                else
                {
                    if (Xc > Xk) Console.WriteLine("Уменьшить Х");
                    if (Xc < Xk) Console.WriteLine("Увеличить Х");
                    if (Yc > Yk) Console.WriteLine("Уменьшить Y");
                    if (Yc < Yk) Console.WriteLine("Увеличить Y");
                }

            }
            if (p == 0) Console.WriteLine("В другой раз...");
            Console.ReadLine();
        }
    }
}
