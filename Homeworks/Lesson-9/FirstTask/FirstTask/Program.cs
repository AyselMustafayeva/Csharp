using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> olkeler = new Dictionary<string, string>();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin.");
            string olke = Console.ReadLine();
            Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin.");
            string weher = Console.ReadLine();
            olkeler.Add(olke, weher);
        }
        Console.WriteLine("Oyunu bawdamaq istiyirsen? (yes/no)");
        string secim = Console.ReadLine();
        while (secim == "Yes" || secim == "yes")
        {
            Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin");
            string olkeadi = Console.ReadLine();
            if (olkeler.ContainsKey(olkeadi))
            {
                Console.WriteLine("Bu olkenin paytaxti : " + olkeler[olkeadi]);
            }
            else if (olkeadi == "all")
            {
                foreach (KeyValuePair<string, string> olkeweher in olkeler)
                {
    
                    Console.WriteLine(olkeweher.Key + "-in paytaxti :  " + olkeweher.Value + " .");
                }
            }

            else
                {
                Console.WriteLine("Sehv datalar, bazada bele olke adi yox, yeniden dahil et");
    }
                Console.WriteLine("Oyunu davam etmek istiyirsen?");
                secim = Console.ReadLine();
            
        }
    }
}