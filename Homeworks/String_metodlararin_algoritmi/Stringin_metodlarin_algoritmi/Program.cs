using System;
using System.Collections.Generic;
public class Program
{
	public static void Main()
	{
		string cumle;
		Substring(out cumle);
		Console.WriteLine("Bolduyumuz hisse: " + cumle);


		Console.WriteLine("Reverse ucun soz dahil edin: ");
		string soz = Console.ReadLine();
		Reverse(ref soz);
		Console.WriteLine("Reverse olunan soz: " + soz);


		Console.WriteLine("Palindrome yoxlamaq ucun soz dahil edin: ");
		string soz2 = Console.ReadLine();
		Palindrome(soz2);

		Console.WriteLine("Tekrarlanan herifleri yiqiwdirmaq ucun metod yazilib, soz dahil edin: ");
		string soz3 = Console.ReadLine();
		Removedublikate(ref soz3);
		Console.WriteLine("Result: " + soz3);

		Console.WriteLine("Bowluqlari yiqiwdirmaq ucun cumleni dahil edin: ");
		string cumle2 = Console.ReadLine();
		Bowluqlar(cumle2);

		Console.ReadLine();
	}

	// 1) String Substring methodunun algorithmini qurun
	//String.substring (int startIndex, int length)
	//Bunun algoritmini quracam. Startindex-bawdanciq index, Length-secdiyimiz sozun uzunluqu.
	//Meselen:string str1 = "Welcome to Csharpstar !! ";
	//Console.WriteLine(str1.Substring(3, 5));
	//Result: come 
	static void Substring(out string cumlemiz)
	{
		Console.WriteLine("Cumlenizi dahil edin: ");
		cumlemiz = Console.ReadLine();
		Console.WriteLine("Bolduyumuz hissenin birinci indexini dahil edin: ");
		int startindex = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Bolduyumuz hisssenin uzunluqunu dahil edin: ");
		int uzunluq = Convert.ToInt32(Console.ReadLine());
		char herif;
		string soz = "";
		for (int i = startindex; i < (uzunluq + startindex); i++)
		{
			herif = cumlemiz[i];
			soz += herif;
		}
		cumlemiz = soz;
	}

	// 2) Reverse methodunun algoritmi qurun : input: hello, output: olleh
	static void Reverse(ref string soz2)
	{
		char herif;
		string reversesoz = "";
		for (int i = (soz2.Length - 1); i >= 0; i--)
		{
			herif = soz2[i];
			reversesoz += herif;
		}
		soz2 = reversesoz;
	}

	// 3) Verilmis sozun palindrome oldugunu yoxlayan algoritm
	// mes:input: ana, output: ana (soldan ve sagdan eyni oxunur)
	static void Palindrome(string soz2)
	{
		char herif;
		string reversesoz = "";
		for (int i = (soz2.Length - 1); i >= 0; i--)
		{
			herif = soz2[i];
			reversesoz += herif;
		}
		if (soz2 == reversesoz)
		{
			Console.WriteLine("True");
		}
		else
		{
			Console.WriteLine("False");
		}
	}

	//4)Remove duplikat olan herfleri silen algoritmini yazin
	//input: csharpcorner, output: csharpone 

	public static void Removedublikate(ref string sozum)
	{

		char[] removearray = new char[sozum.Length];
		int indexi = 0;
		char herif;
		string newsoz = "";

		for (int i = 0; i < sozum.Length; i++)
		{
			for (int j = 0; j < sozum.Length; j++)
			{
				if (sozum[i] == removearray[j])
				{
					break;
				}
				if (i == j)
				{
					removearray[indexi += 1] = sozum[i];
				}
			}

		}

		for (int c = 0; c < removearray.Length; c++)
		{
			herif = removearray[c];
			newsoz += herif;
		}
		sozum = newsoz;
	}

	//5)Optional Sozler arasindaki bosluqlari silen bir method yazmaq.Meselen: "salam menim adim Minadir"
	public static void Bowluqlar(string cumle)
	{
		string newdata = "";
		string[] probelyiqiwdirma = cumle.Split(null);
		foreach (string data in probelyiqiwdirma)
		{
			if (data != null)
			{
				newdata += data;
			}
		}
		Console.WriteLine("Result: "+newdata);
	}
}

//Qalan meseleleri men birinci lesson papkasinda yaratmiwam.Izleye bilersiz.
