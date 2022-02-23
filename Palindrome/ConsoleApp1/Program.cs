using System;

class Polindrom
{
    static void Main()
    {
        
        for (int i = 0; i < 100000; i++)
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            int year = rnd.Next(2023, 2100);
            int day = rnd.Next(1, 32);
            string Month= Convert.ToString(month);
            string Day = Convert.ToString(day);
            string Year = Convert.ToString(year);
            char[] array = Year.ToCharArray();
            Array.Reverse(array);
            string Year2 = null;
           foreach(char x in array)
            {
                Year2 += x;
            }
            if (month < 10)
            {
                Month = "0" + Month;
            }
            if (day < 10)
            {
                Day = "0" + Day;
            }
            if (Day + Month == Year2)
            {
                
                DateTime date1 = DateTime.Today;
                DateTime date2 = new DateTime(year, month, day);
                string ferq = date2.Subtract(date1).ToString();
                Console.WriteLine("Polinrom olan il: " + date2 + "\nPolindrom ilie geder ferq bu gunden saysaq: " + ferq);
                Console.WriteLine("Continue?(Y/N)");
                string secim = Console.ReadLine();
                if (secim == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
            array = null;
            
        }
        


    }
    }

