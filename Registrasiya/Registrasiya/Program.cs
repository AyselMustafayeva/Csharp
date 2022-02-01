using System;
//using System.Collections;
//using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Salam, adinizi dahil edin: ");
        string name = Console.ReadLine();
        Console.WriteLine("Mailinizi dahil edin: ");
        string email = Console.ReadLine();
        Console.WriteLine("Parolunuzu dahil edin: ");
        string password = Console.ReadLine();
        Account user = new Account(name, email, password);
        user.PasswordChecker();
        user.getFullName();


    }
}

 abstract class User
{
    public string Name;
    protected string Password;
    public string Email;
    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
    public abstract  void PasswordChecker();

    public virtual void getFullName()
    {
        Console.WriteLine(this.Name + " " + this.Email);
    }
}

class Account : User
{
    public bool axri;
    public Account(string ad, string email, string parol) : base(ad,email, parol)
    {

    }

    public override void PasswordChecker()
    {
        int sayyekeler = 0;
        int saybalacalar = 0;
        if (this.Password.Length > 8)
        {
            char[] array = Password.ToCharArray();
            for(int i = 0; i < Password.Length; i++)
            {
                if(Char.IsUpper(array[i]))
                {
                    sayyekeler += 1;
                }
                if (Char.IsLower(array[i]))
                {
                    saybalacalar += 1;
                }
            }
            if(sayyekeler!=Password.Length && saybalacalar != Password.Length)
            {
                if(saybalacalar!=0 && sayyekeler != 0)
                {
                    Console.WriteLine("Duz parol yazmisan");
                    axri = true;
                }
                else
                {
                    Console.WriteLine("Sehv parol yazmisan");
                }
            }
            else
            {
                Console.WriteLine("Sehv parol yazmisan");
            }
        }
        else
        {
            Console.WriteLine("Sehv parol yazmisan");
        }
    }

    public override void getFullName()
    {
        if (axri == true)
        {
            Console.WriteLine("Adiniz: " + this.Name + " , Mailiniz:  " + this.Email);
        }
    }

}