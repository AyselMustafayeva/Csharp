using System;
using System.Collections;

namespace vurma_cedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            static void vurma()
            {
                Console.WriteLine("Regemi dahil et: ");
                int regem = Convert.ToInt32(Console.ReadLine());
                int regem2 = 1;
                for(int i = 1; i <= regem; i++)
                {
                    regem2*= i;   
                }
                Console.WriteLine("Vurma cedveli: "+regem2);
            }
            vurma();
            Console.ReadLine();
        }
    }
}