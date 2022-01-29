using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main()
    {
        
        Console.WriteLine(" Bunlardan birini sec:  \n 1- yeni telebe yarat \n 2 - yeni qrup yarat \n 3 - telebenin siyahisini goster \n 4 - qruplarin siyahisini goster \n 5 - qrupa telebe elave et \n 6 - secilmis qrupdaki telebeleri goster \n 7 - sistemden cix");
        string secim = Console.ReadLine();
        Mekteb school = new Mekteb();
        Student user = new Student("Aysel", "Mustafayeva");
        Group grup = new Group("K172", 8);
        while (secim != "7")
        {
            if (secim == "1")
            {
                Console.WriteLine(" Studentin Adini dahil et: ");
                string name = Console.ReadLine();
                Console.WriteLine("Familiyasini dahil et: ");
                string surname = Console.ReadLine();
                user = new Student(name, surname);
                Console.WriteLine("Grup yaranmiyibsa dahil etmek ucun, tezesini yarat, \n yaranibsa qrupu sec(5-e basib) ve dahil et");

            }
            else if (secim == "2")
            {
                Console.WriteLine("Grupun adini dahil et: ");
                string grupname = Console.ReadLine();
                Console.WriteLine("Qrupun sayini dahil et: ");
                int count = Convert.ToInt32(Console.ReadLine());
                grup = new Group(grupname, count);
                Console.WriteLine("Evvel yaratdiqin useri dahil etmek istiyirsen?(Y/N)");
                string secim2 = Console.ReadLine();
                if (secim2 == "Y")
                {
                    grup.AddStudent(user);
                }
                school.Add(grup);
            }
            else if (secim == "3")
            {
                school.Cixartmawaqird();
            }
            else if (secim == "4")
            {
                school.Cixartmagrup();
            }
            else if (secim == "5")
            {
                Console.WriteLine("Olan qrupun adini dahil et:  ");
                string ad = Console.ReadLine();
                Console.WriteLine(" Evvel yaratdiqin userdi yoxsa teze yaradassan(teze/evvel)");
                string dahilete = Console.ReadLine();
                if (dahilete == "evvel")
                {
                    school.Elaveetme(ad,user);
                }
                else
                {
                    Console.WriteLine(" Studentin Adini dahil et: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Familiyasini dahil et: ");
                    string surname = Console.ReadLine();
                    user = new Student(name, surname);
                    school.Elaveetme(ad, user);
                }
            }
            else if (secim == "6")
            {
                Console.WriteLine("Grupun adini dahil et: ");
                string adi = Console.ReadLine();
                school.Cixartmawaqird2(adi);
            }
            Console.WriteLine(" Bunlardan birini sec:  \n 1- yeni telebe yarat \n 2 - yeni qrup yarat \n 3 - telebenin siyahisini goster \n 4 - qruplarin siyahisini goster \n 5 - qrupa telebe elave et \n 6 - secilmis qrupdaki telebeleri goster \n 7 - sistemden cix");
            secim = Console.ReadLine();
        }
    }
}
class Student
{
    public static int No = 0;
    public int Num;
    public string Name;
    public string Surname;
    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
        No++;
        Num=No;
    }
}



class Group
{
    public static int groupnum = 100;
    public int Grnum;
    public int Counts;
     public string Name;
    List<Student> qruppaname = new List<Student>();
    public Group(string name, int count)
    {
        Name = name;
        Counts = count;
        groupnum+=1;
        Grnum=groupnum;
    }
    public void AddStudent(Student user)
    {
        qruppaname.Add(user);
    }
    public void Cixartma()
    {
        foreach (var student in qruppaname)
        {
            Console.WriteLine(student.Num + " " + student.Name + " " + student.Surname);
        }
    }
    public void Uzunluq(Student user)
    {
        if (qruppaname.Count >= Counts)
        {
            Console.WriteLine("Verildiyi uzunluqdan coxdu, elave etmek istiyirsen?(Y/N)");
            string secim3 = Console.ReadLine();
            if (secim3 == "Y")
            {
                AddStudent(user);
            }
            else
            {
                Console.WriteLine("Bazanis doldu.");
            }
        }
        else
        {
            AddStudent(user);
        }
    }

}

class Mekteb
{
    List<Group> mekteb = new List<Group>();
    public void Add(Group grup)
    {
        mekteb.Add(grup);
    }
    public void Cixartmagrup()
    {
        foreach (var grups in mekteb)
        {
                Console.WriteLine(grups.Grnum + " " + grups.Name);
        }
    }

    public void Cixartmawaqird()
    {
        foreach (var grups in mekteb)
        {
            grups.Cixartma();
        }
    }
    public void Elaveetme(string name,Student user)
    {
        foreach(var gruplar in mekteb)
        {
            if (gruplar.Name == name)
            {
                gruplar.Uzunluq(user);
            }
        }
        }
    public void Cixartmawaqird2(string namegrup)
    {
        foreach (var gruplar in mekteb)
        {

            if (gruplar.Name == namegrup)
            {
                gruplar.Cixartma();
            }
        }
    }
}



