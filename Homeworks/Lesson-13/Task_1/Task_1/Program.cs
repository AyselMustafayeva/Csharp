using System;

public class Interface_iwdetme
{
    public static void Main(string[] args)
    {
        Fiqurlar fiqurlar = new Fiqurlar();
        string secim = "Y";
        string secim2;
        while (secim == "Y")
        {
            Console.WriteLine("Salam fiqurun adini yaz: ");
            string fiqure_name = Console.ReadLine();
            if (fiqure_name == "dordbucaq")
            {
                Console.WriteLine("Dordbucaqin perimetrini tapmaq ucun 1 nomresini sec\nsahesini tapmaq ucun 2 nomrsini sec: ");
                secim2 = Console.ReadLine();
                if (secim2 == "1")
                {
                    Console.WriteLine("Dordbucaqin tərəflərini təyin edin:\na: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    fiqurlar.CalculatePerimetr(a, b);
                    Console.WriteLine("Dordbucaqin perimetri: " + fiqurlar.P);
                }
                else if (secim2 == "2")
                {
                    Console.WriteLine("Dordbucaqin tərəflərini təyin edin:\na: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    fiqurlar.CalculateArea(a, b);
                    Console.WriteLine("Dordbucaqin sahesi: " + fiqurlar.S);
                }
                else
                {
                    Console.WriteLine("Sehv regemi yazdiz");
                }
            }
            else if (fiqure_name == "ucbucaq")
            {
                Console.WriteLine("Ucbucaqin perimetrini tapmaq ucun 1 nomresini sec\nsahesini tapmaq ucun 2 nomrsini sec: ");
                secim2 = Console.ReadLine();
                if (secim2 == "1")
                {
                    Console.WriteLine("Ucbucaqin tərəflərini təyin edin:\na: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("c: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    fiqurlar.CalculatePerimetr(a, b,c);
                    Console.WriteLine("Ucbucaqin perimetri: " + fiqurlar.P);
                }
                else if (secim2 == "2")
                {
                    Console.WriteLine("Ucbucaqin tərəflərini təyin edin:\na: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("c: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    fiqurlar.CalculateArea(a, b,c);
                    Console.WriteLine("Ucbucaqin sahesi: " + fiqurlar.S);
                }
                else
                {
                    Console.WriteLine("Sehv regemi yazdiz");
                }
            }
            else if (fiqure_name == "kvadrat")
            {
                Console.WriteLine("Kvadratin perimetrini tapmaq ucun 1 nomresini sec\nsahesini tapmaq ucun 2 nomrsini sec: ");
                secim2 = Console.ReadLine();
                if (secim2 == "1")
                {
                    Console.WriteLine("Kvadratin tərəflərini təyin edin:\na: ");
                    decimal a = Convert.ToDecimal(Console.ReadLine());
                    fiqurlar.CalculatePerimetr(a);
                    Console.WriteLine("Kvadratin perimetri: " + fiqurlar.P);
                }
                else if (secim2 == "2")
                {
                    Console.WriteLine("Kvadratin tərəflərini təyin edin:\na: ");
                    decimal a = Convert.ToDecimal(Console.ReadLine());
                    fiqurlar.CalculateArea(a);
                    Console.WriteLine("Kvadratin sahesi: " + fiqurlar.S);
                }
                else
                {
                    Console.WriteLine("Sehv regemi yazdiz");
                }
            }
            else if (fiqure_name == "daire")
            {
                Console.WriteLine("Dairenin perimetrini tapmaq ucun 1 nomresini sec\nsahesini tapmaq ucun 2 nomrsini sec: ");
                secim2 = Console.ReadLine();
                if (secim2 == "1")
                {
                    Console.WriteLine("Dairenin radiusunu təyin edin:\nr: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    fiqurlar.CalculatePerimetr(r);
                    Console.WriteLine("Dairenin uzunluqu: " + fiqurlar.P);
                }
                else if (secim2 == "2")
                {
                    Console.WriteLine("Dairenin radiusunu təyin edin:\nr: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    fiqurlar.CalculateArea(r);
                    Console.WriteLine("Dairenin sahesi: " + fiqurlar.S);
                }
                else
                {
                    Console.WriteLine("Sehv regemi yazdiz");
                }
            }
            else
            {
                Console.WriteLine("Bu fiqura haqda melumat yox.");
            }
            Console.WriteLine("Davam etmek?(Y/N) :  ");
            secim = Console.ReadLine();
        }
        
    }
}

interface IFigure
{
    void CalculatePerimetr(double a, double b);
    void CalculatePerimetr(decimal a);
    void CalculatePerimetr(double a, double b,double c);
    void CalculatePerimetr(double r);

    void CalculateArea(double a, double b);
    void CalculateArea(decimal a);
    void CalculateArea(double a, double b, double c);
    void CalculateArea(double r);

}


public class Fiqurlar : IFigure
{
    public decimal P;
    public decimal S;
    public void CalculatePerimetr(double a, double b)
    {
         P = Convert.ToDecimal(2 * (a + b));
    }
    public void CalculatePerimetr(decimal a)
    {
        P = 4*a;
    }
    public void CalculatePerimetr(double a, double b, double c)
    {
        P = Convert.ToDecimal(a + b+c);
    }
    public void CalculatePerimetr(double r)
    {
        P = Convert.ToDecimal(2*Math.PI*r);
    }

    public void CalculateArea(double a, double b)
    {
       S = Convert.ToDecimal(a*b);
    }
    public void CalculateArea(decimal a)
    {
        S =a*a;
    }
    public void CalculateArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        S = Convert.ToDecimal(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }
    public void CalculateArea(double r)
    {
        S = Convert.ToDecimal(Math.PI* Math.Pow(r,2));
    }
}