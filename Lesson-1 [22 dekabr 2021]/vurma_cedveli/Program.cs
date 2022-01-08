using System;
using System.Collections;

namespace vurma_cedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regemi dahil et: ");
            int regem = Convert.ToInt32(Console.ReadLine());
            vurma(regem);
            Console.ReadLine();
        }
          static void vurma(int regem)
            {
                int regem2 = 1;
                for(int i = 1; i <= regem; i++)
                {
                    regem2*= i;   
                }
                Console.WriteLine("Vurma cedveli: "+regem2);
            }
    }
}
