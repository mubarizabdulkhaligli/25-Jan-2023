using System;

namespace homework
{
	class Program
	{
		static void Main(string[] args)
		{

			// Task 1.

			string str = "Ali5";
			Console.WriteLine(HasNumber(str));


			//Task 2.

			string Fullname = " Orxan Memmedov";

			Console.WriteLine(IsFullName(Fullname));

			// Task 3.

			int[] numbers = { 1, 2, 6, 7, 1, 2, 6, 7, 8, 898 };

			int[] newArray = MakeUniqueArray(numbers);

			for (int i = 0; i < newArray.Length; i++)
			{
				Console.WriteLine(newArray[i]);
			}



			// Task 4.

			string[] emails = { "ali@gmail.com", "name@gmail.com", "qwe@mail.ru", "ali@mail.ru", "abc@yahoo.com" };

			string[] domains = MakeDomainsArray(emails);

			for (int i = 0; i < domains.Length; i++)
			{
				Console.WriteLine(domains[i]);
			}



			// Task 5.

			string text = " Cumle neye deyilir? Bitmis bir fikri ifade eden soz ve ya soz birlesmesine cumle deyilir.";

			Console.WriteLine(CountSentences(text));

		}



		// Task 1. Verilmiş yazıda rəqəm olub olmadığını tapan metod

		static bool HasNumber(string str)
		{
			for (int i = 0; i < str.Length; i++)
			{
				if (char.IsDigit(str[i]) == true)
				{
					return true;
				}
			}
			return false;
		}


		// Task 2. Verilmiş yazının fullname olub olmadığını tapan metod
		// (fullname olması üçün iki sozdən ibarət olmalıdır
		// və hər bir söz böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)

		static bool IsFullName(string fullname)
		{
			if (string.IsNullOrWhiteSpace(fullname))
				return false;

			fullname = fullname.Trim();

			string[] words = fullname.Split(' ');

			int countWords = words.Length;

			if(countWords==2)
			{
				string name = fullname.Substring(0, fullname.IndexOf(' '));

				string surname = fullname.Substring(fullname.IndexOf(' ') + 1);

				if (IsName(name)==true)
				{
					if (IsName(surname) == true)
						return true;
				}
			}
			return false;
		}



		static bool IsName(string name)
		{
				if (string.IsNullOrWhiteSpace(name))
					return false;

				if (!char.IsUpper(name[0]))
					return false;

				for (int i = 1; i < name.Length; i++)
				{
					if (!char.IsLower(name[i]))
						return false;
				}
				return true;
		}



		// Task 3. Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
		// Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.


		static int[] MakeUniqueArray(int[] array1)
		{
				int[] newArray = new int[0];

				for (int i = 0; i < array1.Length; i++)
				{
					if (Array.IndexOf(newArray, array1[i]) == -1)
					{
						Array.Resize(ref newArray, newArray.Length + 1);

						newArray[newArray.Length - 1] = array1[i];
					}
				}
				return newArray;
		}



		// Task 4. Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.
		// Domainlər arrayində təkrarlanmamlıdır domainlər!

		static string[] MakeDomainsArray(string[] emails)
		{
				string[] DomainsArray = new string[0];

				for (int i = 0; i < emails.Length; i++)
				{
					emails[i] = emails[i].Substring(emails[i].IndexOf("@") + 1);

					if (Array.IndexOf(DomainsArray, emails[i]) == -1)
					{
						Array.Resize(ref DomainsArray, DomainsArray.Length + 1);

						DomainsArray[DomainsArray.Length - 1] = emails[i];
					}
				}
				return DomainsArray;
				{

				}
		}





		// Task 5. Verilmiş yazının içindəki cümlələrin sayını tapan metod.

		static int CountSentences(string text)
		{
			int count = 0;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '.' || text[i] == ':' || text[i] == '?' || text[i] == '!')
				{
					count++;
				}
			}
			return count;
		}
		
	}

}