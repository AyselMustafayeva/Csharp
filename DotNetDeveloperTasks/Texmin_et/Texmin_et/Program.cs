using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Hi.We play the game. I give you first word , but you should find second one. \nYou have 3 chance for it. \nIf you guess right the first time, you get 6 points, \n if you guess right the second time, 4 points, \n if the third time, then 2 points.\nA total of 2 minutes is given.");
        SozOyunu.CumleSozuduzeltme();
        SozOyunu.Oyun();
        
    }
}

public static class SozOyunu
{
     static string cumle="You can gain experience, if you are careful to avoid empty redundancy. Do not fall into the error of the artisan who boasts of twenty years experience in craft while in fact he has had only one year of experience–twenty times. And never resent the advantage of experience your elders have. Recall that they have paid for this experience in the coin of life, and have emptied a purse that cannot be refilled.";
     static string[] sozler=cumle.Split(' ');
      static int point = 0;
    static bool idn = true;
    static int umumisozcutluyusay = 0;
    static int duztapdiqi = 0;
    static int sehvtapdiqi = 0;
    static List<string> sozlercutluyu=new List<string>();
    public static void CumleSozuduzeltme()
    {

        for (int i = 0; i < sozler.Length; i++)
        {
            for(int j = 0; j < sozler[i].Length; j++)
            {
                if(sozler[i][j].ToString() =="." || sozler[i][j].ToString() == ",")
                {
                    sozler[i]=sozler[i].Remove(j);
                }
            }
        }
    }
    
    

    public static void SozTapma()
    {
        if (idn == true)
        {
            string soz0 = " ";
            Random obyekt = new Random();
            int value = obyekt.Next(0, (sozler.Length - 2));

            Console.WriteLine("Your first word is: " + sozler[value] + "\nPlease test your psychic abilities and write the second word: ");
            umumisozcutluyusay += 1;
            string soz = Console.ReadLine();
            if (soz == sozler[value + 1] && idn == true)
            {
                Console.WriteLine("Cool,you can find. You won 6 points. \n Let's play some more.");
                point += 6;
                duztapdiqi += 1;
                SozOyunu.SozTapma();
            }
            else
            {
                Console.WriteLine("Your second chance.\nIf you are finding now, you will win 4 points.");
                soz = Console.ReadLine();
                if (soz == sozler[value + 1] && idn == true)
                {
                    Console.WriteLine("Cool,you can find. You won 4 points.Let's play some more.");
                    point += 4;
                    duztapdiqi += 1;
                    SozOyunu.SozTapma();
                }
                else
                {
                    Console.WriteLine("Your third chance.\nIf you are finding now, you will win 2 points.");
                    soz = Console.ReadLine();
                    if (soz == sozler[value + 1] && idn == true)
                    {
                        Console.WriteLine("Cool,you can find. You won 2 points.");
                        point += 2;
                        duztapdiqi += 1;
                        SozOyunu.SozTapma();
                    }
                    else
                    {
                        Console.WriteLine("Oh,no. You couldn't find.\nDon't pay attention.Let's start over.");
                        sehvtapdiqi+=1;
                        soz0=sozler[value]+" "+sozler[value + 1];
                        sozlercutluyu.Add(soz0);
                        SozOyunu.SozTapma();
                    }

                }
            }
        }
    }

    public static void Result(object nese)
    {
        if (idn == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorry, your time is up.\n Now you will see your result.");
            Console.WriteLine("In total you guessed: " + umumisozcutluyusay + " phrases.");
            Console.WriteLine("You found: " + duztapdiqi + " words eventually.");
            if (umumisozcutluyusay - (duztapdiqi + sehvtapdiqi) != 0)
            {
                int catdirmadiqi = umumisozcutluyusay - (duztapdiqi + sehvtapdiqi);
                Console.WriteLine("You couldn't find " + catdirmadiqi + " words, because your time is up");
            }
            Console.WriteLine("But you gave : " + sehvtapdiqi + " wrong answers and now I show you these correct phrases.");
            foreach (var cutluy in sozlercutluyu)
            {
                Console.WriteLine("Your phrase was : "+cutluy);
            }
            Console.WriteLine("Finally. You scored " + point + " points in total");
            idn = false;
        }
                Console.WriteLine("Game is over, you can go out.");
                Console.ForegroundColor = ConsoleColor.Black;
    }

    public static void Oyun()
    {
        TimerCallback tm = new TimerCallback(SozOyunu.Result);
        Timer timer = new Timer(tm, null, 120000, 0);
        SozOyunu.SozTapma();
    }
}