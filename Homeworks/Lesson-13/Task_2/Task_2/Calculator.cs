using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    interface ISum
    {
        public double Sum(params double[] numbers)
        {
            double summa=0;
            foreach(double num in numbers)
            {
                summa += num;
            }
            return summa;
        }
    }
    interface IMultiply
    {
        public double Vurma(params double[] numbers)
        {
            double vurma = 1;
            foreach (double num in numbers)
            {
                vurma *= num;
            }
            return vurma;
        }
    }
    interface IDifference
    {
        public double Cixma(params double[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            double cixma = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                cixma -= numbers[i];
            }
            return cixma;
        }
    }
    interface IDivide
    {
        public double Bolme(params double[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            double bolme = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                bolme /= numbers[i];
            }
            return bolme;
        }
    }

    public class Calculator:ISum,IMultiply, IDifference, IDivide
    {
    }
}
