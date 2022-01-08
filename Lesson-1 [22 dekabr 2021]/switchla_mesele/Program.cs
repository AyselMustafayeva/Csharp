using System;
using System.Collections;

namespace switchla_mesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 regemini dahil etsez, regemin kvadratina geder butun regemlerin sum-i olan mesele secilecek");
            Console.WriteLine("2 regemini dahil etsez regeme geder sum-in hasila ile fergi olan mesele secilecek");
            int secim = Convert.ToInt32(Console.ReadLine());
            Secimmesele(secim);
            Console.ReadLine();
        }
        
        static void Secimmesele(int secilme){
            switch (secilme)
            {
                case 1:
                    Console.WriteLine("Regemlerin sayini dahil edin: ");
                    int say = Convert.ToInt32(Console.ReadLine());
                    int regem = 0;
                    for (int i = 1; i <= say; i++)
                    {
                        regem = regem +Convert.ToInt32(Math.Pow(i, 2));
                    }
                    Console.WriteLine("Result: " + regem);
                    break;
                case 2:
                    Console.WriteLine("Regemlerin sayini dahil edin: ");
                    int say2 = Convert.ToInt32(Console.ReadLine());
                    int cem = 0;
                    int hasil = 1;
                    for (int i = 1; i <= say2; i++)
                    {
                        cem = cem + i;
                        hasil = hasil * i;
                    }
                    Console.WriteLine("Result: " + (hasil-cem));
                    break;
            }
        }
    }
}
