using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        String secim = "Y";
        while (secim == "Y")
        {
            Console.WriteLine("Please enter your curreny(EUR,USD,TL) : ");
            string currency = Console.ReadLine();
            Console.WriteLine("Enter your quantity (Your curreny is manat now) : ");
            double quantity = Convert.ToDouble(Console.ReadLine());
            ValutaExchanger.Exchange(currency, quantity);
            Console.WriteLine("Do u want to continue?(Y/N)");
            secim=Console.ReadLine();
        }
        ValutaExchanger.Show();

    }
}

static  class ValutaExchanger
{
   public static Dictionary<CurrencyType, double> Curencies = new Dictionary<CurrencyType, double>();
    //public static CurrencyType type1;
    public static void Exchange(string type,double mebleq)
    {
        if (type == "EUR")
        {
            mebleq=mebleq* 0.513;
            if (!Curencies.ContainsKey(CurrencyType.EUR))
            {
                Curencies.Add(CurrencyType.EUR, mebleq);
            }
            else{
                Curencies[CurrencyType.EUR] += mebleq;
            }
            
        }
        if (type == "USD")
        {
            mebleq = mebleq* 0.5886;
            if (!Curencies.ContainsKey(CurrencyType.USD))
            {
                Curencies.Add(CurrencyType.USD, mebleq);
            }
            else
            {
                Curencies[CurrencyType.USD] += mebleq;
            }
        }
        if (type == "TL")
        {
            mebleq=mebleq*7.98;
            if (!Curencies.ContainsKey(CurrencyType.TL))
            {
                Curencies.Add(CurrencyType.TL, mebleq);
            }
            else
            {
                Curencies[CurrencyType.TL] += mebleq;
            }
        }


    }

    public static void Show()
    {
        foreach(var curency_mebleq in Curencies)
        {
            Console.WriteLine(curency_mebleq.Key + ": " + curency_mebleq.Value);
        }
    }

}
public enum CurrencyType
{
    USD,
    EUR,
    TL
}

