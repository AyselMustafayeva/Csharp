using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 2; i++)
        {
            int say = 0;
            string cumle = Console.ReadLine();
            foreach(char bukva in cumle)
            {
                if (Convert.ToString(bukva) == "a")
                {
                    say += 1;
                }
            }
            Console.WriteLine("Cumle : ");
            if (say > 0)
            {
                for(int j = 0; j < say; j++)
                {
                    Console.WriteLine(cumle);
                }
            }
            else
            {
                cumle = null;
                Console.WriteLine("Cumle silindi" + cumle);
            }
            say = 0;
        }
    }
}