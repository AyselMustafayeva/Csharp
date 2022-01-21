using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Book kitab = new Book("Elifba", 30);
        Book[] kitablar = new Book[1];
        kitablar[0] = kitab;
        Adding(ref kitablar);
        foreach (var j in kitablar)
        {
            Console.WriteLine("Kitab adi : " + j.Name + ", Kitab sehfesi : " + j.PageNumber);
        }
    }
    public static void Adding(ref Book[] knijki)
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Kitabin adini dahil edin (min 3 simvol) : ");
            string BookName = Console.ReadLine();

            Console.WriteLine("Kitabin sehife sayini dahil edin (min 10 sehife) : ");
            int BookPage = Convert.ToInt32(Console.ReadLine());

            if (BookName.Length > 3 && BookPage > 10 && knijki.Length<10)
            {
                Array.Resize(ref knijki, knijki.Length + 1);
                Book bookobject = new Book(BookName, BookPage);
                knijki[knijki.Length-1] = bookobject;
            }
            else if (knijki.Length == 10)
            {
                Console.WriteLine("10 kitab dahil olundu. Baza doldu.");
                break;
            }
            else
            {
                Console.WriteLine("Sehv datalar dahil etdiz, yeniden enter et. ");

            }

        }

    }
}



public class Book
{
    public string Name;
    public int PageNumber;

    public Book(string name, int pagenum)
    {
        Name = name;
        PageNumber = pagenum;
    }
}