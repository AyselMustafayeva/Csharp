using System;
namespace Arrayim
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-3
            Console.WriteLine("Regeminizi dahil edin,mende regem cemini tapacam: ");
            string regemim = Console.ReadLine();
            Cemi(regemim);
            TekRegem(regemim);
            //4
            Console.WriteLine("Yawini dahil et: ");
            int yaw = Convert.ToInt32(Console.ReadLine());
            Yaw(yaw);
            //5
            Console.WriteLine("Ayin adini dahil et: ");
            string ay = Console.ReadLine();
            AboutMonth(ay);
            //6-7
            Console.WriteLine("Arrayin uzunluqunu dahil edin: ");
            int say = Convert.ToInt32(Console.ReadLine());
            int[] arrayim = new int[say];
            for (int i = 0; i < say; i++)
            {
                Console.WriteLine("Regemleri dahil edin: ");
                arrayim[i] = Convert.ToInt32(Console.ReadLine());
            }
            Maxi(arrayim);
            Min(arrayim);
            //8. 
            //8.1
            int[] listim = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };
            tekededlerarray(listim);

            //8.2
            ucregemi(listim);
            //8.3
            tekededlerarray(listim);
            //8.4
            siaralama(listim);

            //9
            string[] adlar = { "Aysel", "Narmina", "Sofiya" };
            string[] soyadlar = { "Mustafayeva", "Axundova", "Polyakova" };
          birlewdirmek(adlar, soyadlar);

            //10
            Console.WriteLine("Sozu dahil edin: ");
            string soz = Console.ReadLine();
            axrinciherif(soz);

            //11
            Console.WriteLine("Indi arrayin ve sozun uzunluqunu tapaciyiq, sozu dahil edin: ");
            string soz2 = Console.ReadLine();
            string[] arr2 = { "Moscow", "London", "Baku", "Paris" };
            lengthi(soz2, arr2);
        }

        //2.Verilən 4 rəqəmli ədədin rəqəmlərinin cəmini tapan proqram yazın
        //(Nümunə : int a=1298 Nəticə : 1+2+9+8=20)

        static void Cemi(string regem)
        {
            string val = "";
            int sum = 0;
            for (int i = 0; i < regem.Length; i++)
            {
                val = Convert.ToString(regem[i]);
                sum += Convert.ToInt32(val);
            }
            Console.WriteLine("Regemlerin cemi: " + sum);
        }

        //3.Verilən ədədin rəqəmləri arasında olan tək rəqəmləri ekranda göstərən proqram yazın 
        //(Nümunə : int a=1298 Nəticə : 1,9)

        static void TekRegem(string regem)
        {
            string val = "";
            int num = 0;
            Console.WriteLine("Tek regemler: ");
            for (int i = 0; i < regem.Length; i++)
            {
                val = Convert.ToString(regem[i]);
                num = Convert.ToInt32(val);
                if (num % 2 == 1)
                {
                    Console.WriteLine(num + " ");
                }
            }
        }

        //4.Console.Readline vasitesile ilə istifadəçinin yaşını daxil etməsini istəyin.
        //İstifadəçinin yaşı 30-dan kiçikdirsə istifadəçinin yaşının kvadratını ekrana çap edin
        //Yaş 30-40 aralığındadırsa daxil edilən ədədin son rəqəmini ekrana çap edin
        //Yaş 0-dan kiçik vəya 100-dən böyükdürsə ekrana "Düzgün məlumat daxil etməmisiniz" yazdırın

        static void Yaw(int yaw)
        {

            if (yaw < 30 && yaw > 0)
            {
                yaw = yaw * yaw;
                Console.WriteLine("Result: "+yaw);
            }
            else if (yaw > 30 && yaw < 40)
            {
                yaw = yaw % 10;
                Console.WriteLine("Result: "+yaw);
            }
            else if (yaw > 40 && yaw < 100)
            {
                Console.WriteLine("Good luck");
            }
            else
            {
                Console.WriteLine("Regemi sehv dahil etmisiz");
            }
        }

        // 5. ay dəyəri daxil edildiyi zaman onun necə gun və hansi fesil olduğunu edən method yazın

        static void AboutMonth(string month)
        {
            switch (month)
            {
                case "Yanvar":
                    Console.WriteLine("31 gun, Qiw fesili");
                    break;
                case "Fevral":
                    Console.WriteLine("28-29 gun, Qiw fesili");
                    break;
                case "Mart":
                    Console.WriteLine("31 gun, Yaz fesili");
                    break;
                case "Aprel":
                    Console.WriteLine("30 gun, Yaz fesili");
                    break;
                case "May":
                    Console.WriteLine("31 gun, Yaz fesili");
                    break;
                case "Iyun":
                    Console.WriteLine("30 gun, Yay fesili");
                    break;
                case "Iyul":
                    Console.WriteLine("31 gun, Yay fesili");
                    break;
                case "Avgust":
                    Console.WriteLine("31 gun, Yay fesili");
                    break;
                case "Sentyabr":
                    Console.WriteLine("30 gun, Payiz fesili");
                    break;
                case "Oktybar":
                    Console.WriteLine("31 gun, Payiz fesili");
                    break;
                case "Noyabr":
                    Console.WriteLine("30 gun, Payiz fesili");
                    break;
                case "Dekabr":
                    Console.WriteLine("31 gun, Qiw fesili");
                    break;
            }
        }

        //6. Arrayin en boyuk elementini tapan methiod
        static void Maxi(int[] arrayim)
        {
            Array.Sort(arrayim);
            Array.Reverse(arrayim);
            Console.WriteLine("Max regem: " + arrayim[0]);
        }
        //7. Arrayin en kicik elementini tapan methiod
        static void Min(int[] arrayim)
        {
            Array.Sort(arrayim);
            Console.WriteLine("Min regem: " + arrayim[0]);
        }

        //8.Verilən nums=[1,2,3,6,7,8,23,78,34,12]
        //8.1 Tək ədədlərin cəmini tapan metod yazın
        static void tekededlerarray(params int[] arrayim)
        {
            int sum = 0;
            foreach (int num in arrayim)
            {
                if (num % 2 == 1)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Verildiyi arrayin  int[] listim = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 }; tek ededlerin cemi: " + sum);
        }
        //8.2 Daxilində 3 rəqəmi olan neçə ədəd olduğunu ekrana çap edən metod yazın
        static void ucregemi(params int[] arrayim)
        {
            Console.WriteLine("3 regemi dahilinde olan regemler: ");
            int say = 0;
            foreach (int num in arrayim)
            {
                if (num == 3 || num % 10 == 3 || (((num % 100) - (num % 10)) / 10) == 3)
                {
                    say = say + 1;
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("Sayi: " + say);
        }
        //8.3 Tək ədədləri ayıraraq ayrıca bir massivə yığan metod yazın
        static void tekededlerarrayyiqma(params int[] arrayim)
        {
            int say = 0;
            foreach (int num in arrayim)
            {
                if (num % 2 == 1)
                {
                    say = say + 1;
                }
            }
            int[] tekededler = new int[say];
            int index = 0;
            foreach (int num in arrayim)
            {
                if (num % 2 == 1)
                {
                    tekededler[index++] = num;
                }
            }
            Console.WriteLine("Tek ededler ucun yaradilan massivin elementleri: ");
            foreach (int num in tekededler)
            {
                Console.WriteLine(num + " , ");
            }
        }

        //8.4 Ədədlərin böyükdən kiçiyə doğru sıralayın
        static void siaralama(params int[] arrayim)
        {
            Console.WriteLine("Boyukden kiciye doqru siralama: ");
            Array.Sort(arrayim);
            Array.Reverse(arrayim);
            foreach (int num in arrayim)
            {
                Console.WriteLine(num + "  ");
            }
        }

        //9. 2 ayrı arreyi birləşdirmək.
        static void birlewdirmek(string[] arr1, string[] arr2)
        {
            Console.WriteLine("iki arrayi birlewdirdim, netice: ");
            int uzunluq = arr1.Length + arr2.Length;
            int index = 0;
            string[] arr3 = new string[uzunluq];
            foreach (string word in arr1)
            {
                arr3[index++] = word;
            }
            foreach (string word in arr2)
            {
                arr3[index++] = word;
            }
            foreach (string word in arr3)
            {
                Console.WriteLine(word + " ");
            }
        }


        //10.user-ın daxil etdiyi sözün sonuncu hərfini qaytarmaq.

        static void axrinciherif(string soz)
        {
            char[] character = soz.ToCharArray();
            Array.Reverse(character);
            Console.WriteLine(character[0]);
        }


        //11.Verilen sozun ve ya arrayin Lengthi tapan method yazmaq

        static void lengthi(string soz, string[] array)
        {
            int arrlength = 0;
            int strlength = 0;
            foreach (string sozler in array)
            {
                arrlength += 1;
            }
            char[] newarr = soz.ToCharArray();
            foreach (char character in newarr)
            {
                strlength += 1;
            }
            Console.WriteLine("Sozun uzunluqu: "+strlength + " , Arrayin uzunluqu: " + arrlength);
        }
    }
}