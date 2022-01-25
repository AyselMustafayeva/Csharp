using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        SortedSet<int> Numbers = new SortedSet<int>();
        for(int i = 0; i < 18; i++)
        {
            Console.WriteLine("Num-i dahil et: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Numbers.Add(num);
        }
        foreach(int nums in Numbers)
        {
            Console.WriteLine("Num: " + nums);
        }
    }
}
