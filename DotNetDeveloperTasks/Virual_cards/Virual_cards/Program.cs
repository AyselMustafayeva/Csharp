using System;
using System.Collections.Generic;
class HelloWorld
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, if you want to create a virtual card,then first register your card");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please enter when your main card is deactivated.\nPlease enter the year:  ");
        int year=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the day: ");
        int dayesas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        DateTime esas_card_deactiv= new DateTime(year, month, dayesas);
        Esas_card esascard=new Esas_card(esas_card_deactiv);
        Console.WriteLine("Please enter how much money is in your card: ");
        esascard.Umumipul=Convert.ToInt32(Console.ReadLine());
        string contin = "Y";
        while (contin == "Y")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Now I will list for you what you can do: \nIf you want to create a virtual card, press 1.\nIf you want to see the data of virtual cards, press 2.\nIf you want to see how much money is left in the main card, press 3.\nIf you want to delete a virtual card, press 4.");
            Console.ForegroundColor = ConsoleColor.Red;
            string secim = Console.ReadLine();
            var random2 = new Random();
            Console.ForegroundColor = ConsoleColor.White;
            if (secim == "1" || secim == "Y")
            {
                if (esascard.Umumipul != 0)
                {
                    Console.WriteLine("How much money do you want to invest in the card: ");
                    int pul = Convert.ToInt32(Console.ReadLine());
                    Virual_Card card = new Virual_Card(pul,esascard);
                    Virual_Card.Cardgebulu(card);
                }
                else
                {
                    Console.WriteLine("You don't have money in your main card, so can't create new virtual card.");
                }
            }
            if (secim == "2")
            {
                Virual_Card.ShowYoirVirtualCard();
                
            }
            if (secim == "3")
            {
                Esas_card.ShowEsasCardPul(esascard);

            }
            if (secim == "4")
            {
                
                Virual_Card.CardRemove(esascard);

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do u want continue?(Y/N)\n'if you enter yes,then enter,what u want to do.'");
            contin = Console.ReadLine();

        }
    }
}



public class Virual_Card
{
    string bankkart;
    int mebleq;
    DateTime time;
    static List<Virual_Card> card_yiqan = new List<Virual_Card>();

    public Virual_Card(int pul, Esas_card obyect)
    {
        while (obyect.Umumipul < pul)
        {
            Console.WriteLine("Your card has less money, please re-enter");
            pul = Convert.ToInt32(Console.ReadLine());
        }
        mebleq = pul;
        obyect.Umumipul -= mebleq;
        DateTime time2 = DateTime.Now;
        Console.WriteLine("Enter how many days your card will be active starting from today: ");
        int days = Convert.ToInt32(Console.ReadLine());
        time = time2.AddDays(days);
        while (obyect.Data.Subtract(time).Hours<0)
        {
            Console.WriteLine("sorry, but the time of your deactivation must not exceed the time of deactivation of the main card");
            Console.WriteLine("Please, enter again: ");
            time2 = DateTime.Now;
            days = Convert.ToInt32(Console.ReadLine());
            time = time2.AddDays(days);
        }
        
        var random = new Random();
        for (int i = 0; i < 16; i++)
        {
            bankkart = String.Concat(bankkart, random.Next(10).ToString());
        }
    }
    public static void Cardgebulu(Virual_Card card)
    {
        if (card_yiqan.Count < 5)
        {
            card_yiqan.Add(card);
            Console.WriteLine("Your card will be registered.");
        }
        else
        {
            Console.WriteLine("Sorry, you have already created 5 сards.\nIf you want to create a new one,\nthen delete one of the other cards ");
        }
    }
    public static void CardRemove(Esas_card obyect)
    {
        if (card_yiqan.Count == 0)
        {
           
            Console.WriteLine("You don't create a card");
            
        }
        else {
            int say = 0;
            Console.WriteLine("Please enter your card number and your card will be deleted");
            string nomresi = Console.ReadLine();
            for (int j = 0; j < card_yiqan.Count; j++)
            {
                
                    if (card_yiqan[j].bankkart == nomresi)
                    {
                        obyect.Umumipul += card_yiqan[j].mebleq;
                        card_yiqan.Remove(card_yiqan[j]);
                        Console.WriteLine("This card was deleted");
                    }
                    else
                     {
                    say += 1;
                    }
                
            }
            if ((say-1) == card_yiqan.Count)
            {
                Console.WriteLine("You entered the wrong card number");
            }
        }
    }

    public static void ShowYoirVirtualCard()
    {
        Console.WriteLine("Here you see your virtual cards number and and the time of their deactivation");
        if (card_yiqan.Count == 0)
        {
            Console.WriteLine("You didn't create a card");
            
        }
        else
        {
            for (int k = 0; k < card_yiqan.Count; k++)
            {
                int num = k + 1;
                Console.WriteLine(num + ". Number: " + card_yiqan[k].bankkart + "\nTime of the deactivation: " + card_yiqan[k].time + "\nAmount of money: " + card_yiqan[k].mebleq);

            }
        }
    }

}
public class Esas_card
{
     int umumipul;
     string nomresi;
     DateTime timeEsas;

    public Esas_card(DateTime time)
    {
        
        
        bool result = true;
        int say = 0;
        while (result)
        {
            Console.WriteLine("Please,enter your main card number( The number must contain 16 numbers) : ");
            string nomre = Console.ReadLine();
            char[] arrayim = nomre.ToCharArray();
            if (nomre.Length == 16)
            {
                for(int n = 0; n < arrayim.Length; n++)
                {
                    if (Char.IsDigit(arrayim[n]))
                    {
                        say += 1;
                    }
                }
                if (say == arrayim.Length)
                {
                    nomresi = nomre;
                    result = false;
                }
            }
        }
        timeEsas = time;
    }
    public int Umumipul
    {
        get { return umumipul; }
        set { umumipul = value; }
    }
    public DateTime Data
    {
        get { return timeEsas; }
        set { timeEsas = value; }
    }
    public Esas_card(){

        }
    public static void ShowEsasCardPul(Esas_card obyect)
    {
       
        Console.WriteLine("On your main сard is " + obyect.Umumipul + " AZN.");
    }
}