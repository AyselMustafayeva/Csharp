using System;

public class Account_users
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi,Users. Sinifde nece waqird olduqunu dahil edin ve registrasiyadan kecin.Bildirim ki bir wansiniz var.");
        int nums = Convert.ToInt32(Console.ReadLine());
        int say = 0;
        for (int k = 0; k < nums; k++) { 
            Console.WriteLine("Username-ni dahil et: ");
            string name = Console.ReadLine();
            Console.WriteLine("Password-u dahil et: ");
            string password = Console.ReadLine();
            IsUsernameisValid(ref name);
            IsPasswordisValid(ref password);
            if (name != "Invalid sentence" && password != "Invalid sentence")
            {
                Registr user = new Registr(name, password);
                Console.WriteLine(Registr.No + " user is : " + user.UserName);
            }
           
        }
       
    }
        static void IsUsernameisValid(ref string name)
        {
            int say1 = 0;
            int say2 = 0;
            string newname = " ";
            char[] array = name.ToCharArray();
            foreach (char ex in array)
            {
                if (Char.IsDigit(ex))
                {
                    say1++;
                }
                if (Char.IsLetter(ex))
                {
                    say2++;
                }
            }
            if (say1 > 0 && say2 > 0 && (say1 + say2) == name.Length)
            {
                newname = name;
            }
            else
            {
                newname = "Invalid sentence";
            }
            name = newname;
        }
       static void IsPasswordisValid(ref string password)
        {
            if (password.Length >= 8 && password.Length <= 25)
            {
                int say1 = 0;
                int say2 = 0;
                int say3 = 0;
                string newpassword = " ";
                foreach (char ch in password)
                {
                    if (Char.IsSymbol(ch))
                    {
                        say1++;
                    }
                    if (Char.IsDigit(ch))
                    {
                        say2++;
                    }
                    if (Char.IsUpper(ch))
                    {
                        say3++;
                    }
                }
                if (say1 > 0 && say2 > 0 && say3 > 0)
                {
                    newpassword = password;
                }
                else
                {
                    newpassword = "Invalid sentence";
                }
                password = newpassword;
            }
        }
    }
public class Registr
{
    public string UserName=" ";
    public string Password=" ";
    public static int No = 0;
    public Registr(string username, string password)
    {
        UserName=username;
        Password=password;
        No++;
    } 
}