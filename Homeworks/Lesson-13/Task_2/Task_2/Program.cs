using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Interface_iwtetmeq
{
    public static void Main(string[] args)
    {
        Console.WriteLine("4 operasiya etmek olar, birini sec\n1.toplama\n2.vurma\n3.cixma\n4.bolme");
        string secim = Console.ReadLine();
        if (secim == "1")
        {
            Task_2.ISum calk1 = new Task_2.Calculator();
            Console.WriteLine("Sum results: "+calk1.Sum(23, 54, 10, 14, 33, 6, 4));
        }
        else if (secim == "2")
        {
            Task_2.IMultiply calk1 = new Task_2.Calculator();
            Console.WriteLine("Vurma results: " + calk1.Vurma(5, 4, 8, 10));
        }
        else if (secim == "3")
        {
            Console.WriteLine("Yeke regemnen balacani cixa cixa gedecek.");
            Task_2.IDifference calk1 = new Task_2.Calculator();
            Console.WriteLine("Cixmaq results: " + calk1.Cixma(21,19,33,88,200,20));
        }
        else if (secim == "4")
        {
            Console.WriteLine("Yeke regemnen balacani bole bole gedecek.");
            Task_2.IDivide calk1 = new Task_2.Calculator();
            Console.WriteLine("Bolmeq results: " + calk1.Bolme(3, 8, 20, 6, 800, 1,9,3,11));
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}