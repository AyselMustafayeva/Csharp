using System;
using System.Collections;

namespace orta_eded
{
    class Program
    {
        static void Main(string[] args)
        {
            
            orta();
            Console.ReadLine();
        }
        static void orta()
            {
                Console.WriteLine("Regemlerin sayini dahil et: ");
                int say = Convert.ToInt32(Console.ReadLine());
                double summa = 0;
                double ortaeded = 0;
                for(int i=0; i < say; i++)
                {
                    Console.WriteLine("Regemi dahil et: ");
                    int regem = Convert.ToInt32(Console.ReadLine());
                    summa=summa+ regem;
                    ortaeded = summa / say;
                }
                Console.WriteLine("Orta eded = "+Math.Round(ortaeded,3));

            }
    }
}
