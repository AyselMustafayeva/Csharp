using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int> arrayim1 = new List<int>();
        List<int> arrayim2 = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter your num : ");
            int num = Convert.ToInt32(Console.ReadLine());
            arrayim1.Add(num);
        }
          for(int j = 5; j < 10; j++)
        {
            arrayim2.Add(arrayim1[j]);
        }
          for(int k = 0; k < 5; k++)
        {
            arrayim2.Add(arrayim1[k]);
        }
        foreach (int num in arrayim2)
        {
            Console.WriteLine("Num: " + num);
        }
    }
}
