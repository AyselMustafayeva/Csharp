using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Queue<string> sozler = new Queue<string>();
        List<string> sozler2 = new List<string>();
        Console.WriteLine("Sozu dahil etmek istiyirsen? (Y/N). 10 dan cox soz dahil etmelisiz.");
        string secim = Console.ReadLine();
        while (secim == "Y")
        {
            Console.WriteLine("Sozu dahil edin: ");
            string soz = Console.ReadLine();
            sozler.Enqueue(soz);
            if (sozler.Count > 10)
            {
                Console.WriteLine("Yene soz dahil etmek istiyirsen? (Y/N)");
                secim = Console.ReadLine();
            }
        }
        if (sozler.Count > 10)
        {
            Console.WriteLine("baza doldu, axrinci sozu deyiw");
            Console.WriteLine("Teze sozu dahil edin: ");
            foreach (string soz in sozler)
            {
                sozler2.Add(soz);
                if (sozler2.Count==9)
                {
                    string newsoz = Console.ReadLine();
                    sozler2.Add(newsoz);
                    break;
                }
            }
        }

        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("Bizim sozlerimiz: " + sozler2[j]);
        }
    }
}