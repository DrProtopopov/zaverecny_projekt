using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAVERECNY_PROJEKT
{
	class Program
	{
		static void Main(string[] args)
		{
            Evidence evidence = new Evidence();
            char volba = '0';
            while (volba != '4')
            {
                Console.Clear();
                Console.WriteLine
               ("_____________________________\n" +
                "Evidence pojištěných\n" +
                "_____________________________\n\n" +
                "Vyberte si akci:\n" +
                "1 - Přidat nového pojištěného\n" +
                "2 - Vypsat všechny pojištěné\n" +
                "3 - Vyhledat pojištěného\n" +
                "4 - Konec");
                volba = Console.ReadKey().KeyChar;
                switch (volba)
                {
                    case '1':
                        Console.WriteLine("");
                        evidence.PridejZaznam();
                        break;
                    case '2':
                        Console.WriteLine("");
                        evidence.VypisVsechnyZaznamy();
                        break;
                    case '3':
                        Console.WriteLine("");
                        evidence.VyhledejZaznamy();
                        break;
                    case '4':
                        Console.WriteLine("");
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
                
            }

        }
	}
}