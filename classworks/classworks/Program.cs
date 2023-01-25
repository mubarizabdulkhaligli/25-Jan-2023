using System;

namespace classworks
{
	class Program
	{
		static void Main(string[] args)
		{
			// Task 1.

			Console.WriteLine(IsName("Memmed"));


			// Task 2.

			string[] fullnames = { "     Ehmed Eliyev    ", "Hikmet Abbasov", "Nermin Quliyeva" };

			MakeNameArray(fullnames);

			for (int i = 0; i < fullnames.Length; i++)
			{
				Console.WriteLine(fullnames[i]);
			}


			// Task 3.

			string[] array1 = { "alma", "armud", "heyva", "alma", "nar" };

			string[] array2 =MakeUniqueArray(array1);

			for (int i = 0; i < array2.Length; i++)
			{
				Console.WriteLine(array2[i]);
			}


			// Task 4. 

			string name = "HikMaT";
			Console.WriteLine(Capitalize(name));


			// Task 5. Adinizi sehv yazdiqca yeniden daxil etmeyinizi isteyen proqram

			string ad;
			do
			{
				Console.WriteLine("Adinizi daxil edin: ");
				ad = Console.ReadLine();

			} while (!IsName(ad));


			// Task 6. E-maili sehv yazdiqca yeniden daxil etmeyinizi isteyen proqram

			string email;

			do
			{
				Console.WriteLine("E-maili daxil edin: ");
				email = Console.ReadLine();

			} while (!email.Contains("@"));


			// Task 7.

			Console.WriteLine(GetDomain(email));
        }




        // Task 1. Verilmis yazinin ad olub olmadigini tapan metod
        // Yazi addirsa boyuk herfle baslamali ve kicik herfle davam etmelidir

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


		// Task 2. Verilmis fullname siyahisindan name siyahisi duzelib qaytaran metod

		static string[] MakeNameArray(string[] fullnames)
		{
			string[] newArray = new string[fullnames.Length];

			for (int i = 0; i < fullnames.Length; i++)
			{
				fullnames[i] = fullnames[i].Trim();

				fullnames[i] = fullnames[i].Substring(0, fullnames[i].IndexOf(" "));

				newArray[i] = fullnames[i];
			}
			return newArray;
		}


		// Task 3. Verilmis string arrayinin icerisindeki tekrarlanmayan deyerlerden ibaret yeni bir array qaytaran metod

		static string[] MakeUniqueArray(string[] array1)
		{
			string[] newArray = new string[0];

			for (int i = 0; i < array1.Length; i++)
			{
				if (Array.IndexOf(newArray, array1[i]) == -1)
				{
                    Array.Resize(ref newArray, newArray.Length + 1);

                    newArray[newArray.Length-1] = array1[i];
                }	
			}
			return newArray;
		}


		// Task 4. Verilmis yazini bas herfi boyuk digerleri kicik halda qaytaran metod

		static string Capitalize(string name)
		{
			string newName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
			return newName;
		}


        //Task 7. Verilen e-mailin domain hissesini qaytaran metod

		static string GetDomain(string email)
		{
			string domain = email.Substring(email.IndexOf("@")+1);
			return domain;
		}
		
    }
}

