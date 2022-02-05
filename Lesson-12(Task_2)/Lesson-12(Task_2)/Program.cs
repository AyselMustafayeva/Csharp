using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Salam. Satiw elemek ucun 1 regemine basin,\n satiwi silmek ucun 2 regemine.");
        string secim = Console.ReadLine();
        while (secim == "1" || secim == "2")
        {
            if (secim == "1")
            {
                Console.WriteLine("Odemek ucun valutani secin : ");
                string currency = Console.ReadLine();
                Console.WriteLine("Odemek mebleqini secin: ");
                double mebleq = Convert.ToDouble(Console.ReadLine());
                CashRegister.AddSale(mebleq, currency);

            }
            else if (secim == "2")
            {
                Console.WriteLine("Sildirmek ucun valutani secin : ");
                string currency = Console.ReadLine();
                Console.WriteLine("Sildirmek mebleqini secin: ");
                double mebleq = Convert.ToDouble(Console.ReadLine());
                CashRegister.RemoveSale(currency,mebleq);
            }
            Console.WriteLine("davam etmek istiyirsiz? \n Satiw elemek ucun 1 regemine basin,\n satiwi silmek ucun 2 regemine. \n Eger sistemnen cixmaq istiyirsiz, bawqa regeme basin.");
            secim = Console.ReadLine();
        }
        CashRegister.Show();
    }
}
public static class CashRegister
{
    public static double TotalAmount;
    public static int TotalSalesCount=0;
    public static int TotalRemoveCount = 0;
    public static CurrencyType Currency;
    public static Dictionary<CurrencyType,double> dict = new Dictionary<CurrencyType,double>();



    public static  void AddSale(double mebleq,string currency)
    {
        Console.WriteLine("Kassanin valutasini secin: ");
        string currency2 = Console.ReadLine();
        if (currency2 == "EUR")
        {
            
            if (!dict.ContainsKey(CurrencyType.EUR)) { 
                dict.Add(CurrencyType.EUR, mebleq);
                TotalSalesCount++;
            }
            else
            {
                
                if(currency2 == currency)
                {
                    dict[CurrencyType.EUR] += mebleq;
                    TotalSalesCount++;
                }
                else
                {
                    if (currency == "AZN")
                    {
                        mebleq = mebleq * 0.513;
                        dict[CurrencyType.EUR] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "USD")
                    {
                        mebleq = mebleq * 0.87344;
                        dict[CurrencyType.EUR] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "TL")
                    {
                        mebleq = mebleq * 0.064486;
                        dict[CurrencyType.EUR] += mebleq;
                        TotalSalesCount++;
                    }
                }
            }

        }
        else if (currency2 == "USD")
        {
            if (!dict.ContainsKey(CurrencyType.USD))
            {
                dict.Add(CurrencyType.USD, mebleq);
                TotalSalesCount++;
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.USD] += mebleq;
                    TotalSalesCount++;
                }
                else
                {
                    if (currency == "AZN")
                    {
                        mebleq = mebleq * 0.5886;
                        dict[CurrencyType.USD] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "EUR")
                    {
                        mebleq = mebleq * 1.14;
                        dict[CurrencyType.USD] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "TL")
                    {
                        mebleq = mebleq * 0.073704;
                        dict[CurrencyType.USD] += mebleq;
                        TotalSalesCount++;
                    }
                }
            }
        }
        if (currency2 == "AZN")
        {
            if(!dict.ContainsKey(CurrencyType.AZN))
            {
                dict.Add(CurrencyType.AZN, mebleq);
                TotalSalesCount++;
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.AZN] += mebleq;
                    TotalSalesCount++;
                }
                else
                {
                    if (currency == "USD")
                    {
                        mebleq = mebleq * 1.7;
                        dict[CurrencyType.AZN] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "EUR")
                    {
                        mebleq = mebleq * 1.95;
                        dict[CurrencyType.AZN] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "TL")
                    {
                        mebleq = mebleq * 0.12533;
                        dict[CurrencyType.AZN] += mebleq;
                        TotalSalesCount++;
                    }
                }
            }
        }
        if (currency2 == "TL")
        {
            if (!dict.ContainsKey(CurrencyType.TL))
            {
                dict.Add(CurrencyType.TL, mebleq);
                TotalSalesCount++;
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.TL] += mebleq;
                    TotalSalesCount++;
                }
                else
                {
                    if (currency == "USD")
                    {
                        mebleq = mebleq * 13.57;
                        dict[CurrencyType.TL] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "EUR")
                    {
                        mebleq = mebleq * 15.51;
                        dict[CurrencyType.TL] += mebleq;
                        TotalSalesCount++;
                    }
                    if (currency == "AZN")
                    {
                        mebleq = mebleq * 7.98;
                        dict[CurrencyType.TL] += mebleq;
                        TotalSalesCount++;
                    }
                }
            }
        }
    }

    public static void RemoveSale(string currency, double mebleq)
    {
        Console.WriteLine("Kassanin valutasini sec: ");
        string currency2 = Console.ReadLine();
        if (currency2 == "EUR")
        {

            if (!dict.ContainsKey(CurrencyType.EUR))
            {
                Console.WriteLine("Bu kassada satiw aparilmiyib.");
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.EUR] -= mebleq;
                    TotalRemoveCount++;
                }
                else
                {
                    if (currency == "AZN")
                    {
                        mebleq = mebleq * 0.513;
                        dict[CurrencyType.EUR] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "USD")
                    {
                        mebleq = mebleq * 0.87344;
                        dict[CurrencyType.EUR] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "TL")
                    {
                        mebleq = mebleq * 0.064486;
                        dict[CurrencyType.EUR] -= mebleq;
                        TotalRemoveCount++;
                    }
                }
            }

        }
        else if (currency2 == "USD")
        {
            if (!dict.ContainsKey(CurrencyType.USD))
            {
                Console.WriteLine("Bu kassada satiw aparilmiyib.");
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.USD] -= mebleq;
                    TotalRemoveCount++;
                }
                else
                {
                    if (currency == "AZN")
                    {
                        mebleq = mebleq * 0.5886;
                        dict[CurrencyType.USD] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "EUR")
                    {
                        mebleq = mebleq * 1.14;
                        dict[CurrencyType.USD] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "TL")
                    {
                        mebleq = mebleq * 0.073704;
                        dict[CurrencyType.USD] -= mebleq;
                        TotalRemoveCount++;
                    }
                }
            }
        }
        if (currency2 == "AZN")
        {
            if (!dict.ContainsKey(CurrencyType.AZN))
            {
                Console.WriteLine("Bu kassada satiw aparilmiyib.");
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.AZN] -= mebleq;
                    TotalRemoveCount++;
                }
                else
                {
                    if (currency == "USD")
                    {
                        mebleq = mebleq * 1.7;
                        dict[CurrencyType.AZN] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "EUR")
                    {
                        mebleq = mebleq * 1.95;
                        dict[CurrencyType.AZN] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "TL")
                    {
                        mebleq = mebleq * 0.12533;
                        dict[CurrencyType.AZN] -= mebleq;
                        TotalRemoveCount++;
                    }
                }
            }
        }
        if (currency2 == "TL")
        {
            if (!dict.ContainsKey(CurrencyType.TL))
            {
                Console.WriteLine("Bu kassada satiw aparilmiyib.");
            }
            else
            {

                if (currency2 == currency)
                {
                    dict[CurrencyType.TL] -= mebleq;
                    TotalRemoveCount++;
                }
                else
                {
                    if (currency == "USD")
                    {
                        mebleq = mebleq * 13.57;
                        dict[CurrencyType.TL] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "EUR")
                    {
                        mebleq = mebleq * 15.51;
                        dict[CurrencyType.TL] -= mebleq;
                        TotalRemoveCount++;
                    }
                    if (currency == "AZN")
                    {
                        mebleq = mebleq * 7.98;
                        dict[CurrencyType.TL] -= mebleq;
                        TotalRemoveCount++;
                    }
                }
            }
        }
    }

 public static void Show()
    {
        Console.WriteLine("Umumi butun kassalarda yiqildiqi mebleq \n AZN valutasinda gosterilecek.");

        TotalAmount = dict[CurrencyType.USD] * 1.7 + dict[CurrencyType.EUR] * 1.95 + dict[CurrencyType.TL] * 0.12533 + dict[CurrencyType.AZN];
        Console.WriteLine("Umumi kassada :  " + TotalAmount + " AZN var");

        Console.WriteLine("Umumi satiw sayi: " + TotalSalesCount + " \n amma umumi silindirmek sayi :  " + TotalRemoveCount);
    }
}



public enum CurrencyType
{
    USD,
    EUR,
    TL,
    AZN
}