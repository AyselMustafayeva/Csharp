using System;

public class Studentler
{
    public static void Main(string[] args)
    {
        Students[] array1 = new Students[8];
        byte[] array2 = new byte[8];
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Enter your fullname: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Group number: ");
            byte groupno = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter your age: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Students uwaq = new Students(name, groupno, age);
            array1[i] = uwaq;
            array2[i] = groupno;
        }

        foreach (var item in array1)
        {
            item.GetBirthYear();
        }
        Console.WriteLine("Grupun nomresini dahil edin ve baxaq nece waqird bir qrupda var");
        byte axtarilanqrup = Convert.ToByte(Console.ReadLine());
        Grupdaneceuwaq(array2, axtarilanqrup);
    }
    static void Grupdaneceuwaq(byte[] array2, byte num)
    {
        byte say = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            if (num == array2[i])
            {
                say += 1;
            }
        }
        Console.WriteLine("Bu qrupda ( group No is " + num + " ) , " + say + " waqird var.");
    }
    public class Students
    {
        public string Fullname;
        public byte GroupNo;
        public byte Age;

        public Students(string name, byte groupno, byte age)
        {
            Fullname = name;
            GroupNo = groupno;
            Age = age;
        }
        public void GetBirthYear()
        {
            int BirthYear = DateTime.Now.Year - Age;
            Console.WriteLine(Fullname + ", your birth year is : " + BirthYear);
        }
    }
}
