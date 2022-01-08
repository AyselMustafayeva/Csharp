using System;
using System.Collections;

namespace duzbucaq
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Duzbucaqin uzunluqunu dahil et: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Duzbucaqin enini dahil et: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Perimetr(a, b);
                Sahesi(a, b);
            Console.ReadLine();
        }
         static void Perimetr ( int x, int y)
            {
                int Per = 2 * (x + y);
                Console.WriteLine("Duzbucaqin perimetri: " + Per);

            }
            static void Sahesi (int x, int y)
            {
                int Sahe = x*y;

                Console.WriteLine("Duzbucaqin sahesi: " + Sahe);

            }
    }
}
