using System;
using System.Collections;

namespace Ref_ve_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int regem1;
            Out(out regem1);
            Console.WriteLine("Out iwletsek: "+regem1);

            Console.WriteLine("Regemi dahil et: ");
            int regem2 = Convert.ToInt32(Console.ReadLine());
            regem2=Yoxlama(regem2);
            Console.WriteLine("Yoxlamaq ucun methodu: " + regem2);

            Console.WriteLine("Regemi dahil et: ");
            double regem3 = Convert.ToDouble(Console.ReadLine());
            Ref(ref regem3);
            Console.WriteLine("Raf iwletsek: " + regem3);
        }

        static void Out(out int num)
        {
            Console.WriteLine("Regemi dahil et: ");
            num = Convert.ToInt32(Console.ReadLine());
            int vurma = 0;
            int summa = 0;
            for(int i = 1; i <= num; i++)
            {
                vurma = num * i;
                summa += vurma;
            }
            num = summa;
        }

        static int Yoxlama(int num2)
        {
            num2 = Convert.ToInt32(Math.Pow((double)num2,3));
            return num2;
        }


        static void Ref(ref double num3)
        {
            double vurma = 0;
            double summa = 0;
            for (int i = 1; i <= num3; i++)
            {
                vurma = i*num3;
                summa += vurma;
                
            }
            num3 = Math.Sqrt(summa);
        }
    }
}