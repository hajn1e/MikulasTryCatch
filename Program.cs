using System.Threading.Channels;

namespace MikulasTryCatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Üdvözöllek a Mikulás segítőjében!");
			Console.WriteLine("Segíts a mikulásnak megadni, hány jó gyerek van a listában");

			int joGyerekSzama = 0;
			bool siker = false;

			while (!siker)
			{
				Console.WriteLine("Kérlek add meg a jó gyerekek számát: ");
				string input = Console.ReadLine();

				try
				{
					//megpróbáljk a bemenet számát egész számmá alakítani
					joGyerekSzama = Convert.ToInt32(input);

					if (joGyerekSzama < 0)
					{
						throw new Exception("A gyerekek száma nem lehet negatív!");

					}
				}
				catch (OverflowException)
				{
                    //2.147.483.647
                    Console.WriteLine("Túl léptük a keretet");
                }
				catch (FormatException)
				{
					Console.WriteLine("Hiba: Csak számokat adhatsz meg!");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Hiba {ex.Message}");
				}
			}
            Console.WriteLine($"Köszönöm! A mikulás listáján {joGyerekSzama} jó gyerek van!");
			Console.ReadLine();
			*/

			/* 1. feladat
			Console.WriteLine("Adj meg a gyerek nevét: ");
			string nev = Console.ReadLine();

			Console.WriteLine($"Hány ajándékot kapjon {nev}");
			try
			{
				int ajandekSzama = Convert.ToInt32(Console.ReadLine);
				if (ajandekSzama < 0)
				{
					throw new Exception("Az ajándékok száma nem lehet negatív!");
				}
				Console.WriteLine($"{nev} {ajandekSzama} ajándékot fog kapni!");
			}
			catch (FormatException)
			{
				Console.WriteLine("Csak számot lehet megadni");
			}
			catch (Exception ex) 
			{
				Console.WriteLine($"Hiba {ex.Message}");
			}
			*/
			/*2.feladat
			int[] raktar = { 10, 5, 0 }; // ajandekok: jatekok, edessegek, ruhak
			string[] ajandekTipusok = { "játék", "édességek", "ruha" };

            for (int i = 0; i < raktar.Length; i++)
			{
				Console.WriteLine($"{ajandekTipusok[i]}: {raktar[i]} db raktáron");
				if ( raktar[i] == 0)
				{
                    Console.WriteLine($"Nincs elég {ajandekTipusok[i]}! Töltsd fel a raktárat: ");
					try
					{
						int feltoltes = Convert.ToInt32(Console.ReadLine());
                        if (feltoltes < 0)
                        {
							throw new Exception("A feltöltési mennyiségnek pozitívnak kell lenni");

                        }
						raktar[i] += feltoltes;
                        Console.WriteLine($"A raktár feltöltve: {raktar[i]} db {ajandekTipusok[i]}");
                  }
					catch (FormatException)
					{
                        Console.WriteLine("Hiba: Csak számot lehet megadni ");
                    }
					catch (Exception ex)
					{
                        Console.WriteLine($"Hiba: {ex.Message}");
                    }*/
			//3.feladat
			Console.WriteLine("Hány gyerek kapott ajándékot?");
			int gyerekekSzama = 0;
			while (true) 
			{
				try
				{
					gyerekekSzama = Convert.ToInt32(Console.ReadLine());
					if (gyerekekSzama <= 0)
						throw new Exception("A gyerekek száma pozitív egész szám kell legyen");
					break;
				}
				catch (Exception ex) 
				{
                    //hogy lássuk milyen exeption jött létre
                    //Console.WriteLine(ex.ToString);
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
			}

			int osszErtek = 0;
            for (int i = 0; i < gyerekekSzama; i++)
            {
                Console.WriteLine($"Mennyi az {i} gyerekek ajándékának értéke?");
				try
				{
					int ertek = Convert.ToInt32(Console.ReadLine());
					if (ertek < 0) 
						throw new Exception("Az ajándék értéke nem lehet negatív");
					osszErtek += ertek;
				}catch(Exception ex)
				{
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
            Console.WriteLine($"Az ajándékok összértéke: {osszErtek} Ft");

        }
	}
}
                


