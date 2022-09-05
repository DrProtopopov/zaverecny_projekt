using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAVERECNY_PROJEKT
{
    class Evidence
    {
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }

        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej jméno znovu:");
            }
            
            
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej příjmení znovu:");
            }
            
            
            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            string tel;
            while (string.IsNullOrWhiteSpace(tel = Console.ReadLine()))
            {
                Console.WriteLine("Zadej telefonní číslo znovu:");
            }
            
            
            Console.WriteLine("Zadejte věk pojištěného:");
            string vek;
            while (string.IsNullOrWhiteSpace(vek = Console.ReadLine()))
            {
                Console.WriteLine("Zadej věk znovu:");
            }
            databaze.PridejZaznam(jmeno, prijmeni, tel, vek);
            Console.WriteLine("Uživatel byl přidán do databáze");
            Console.WriteLine("Libovolnou klávesou se vraťe do menu voleb");
        }

        public void VyhledejZaznamy()
        {

            List<Zaznam> zaznamyZkontroluj = databaze.VsechnyZaznamy();
            if (zaznamyZkontroluj.Count() > 0)
            { 
                Console.WriteLine("Zadejte jméno pojištěného:");
                string jmeno;
                while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
                {
                    Console.WriteLine("Zadej jméno znovu:");
                }


                Console.WriteLine("Zadejte příjmení pojištěného:");
                string prijmeni;
                while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
                {
                    Console.WriteLine("Zadej jméno znovu:");
                }
                List<Zaznam> zaznamy = databaze.NajdiZaznamy(jmeno, prijmeni);
                if (zaznamy.Count() > 0)
                {
                    Console.WriteLine("Nalezeny tyto záznamy: ");
                    foreach (Zaznam z in zaznamy)
                        Console.WriteLine(z);
                    
                }
                else
                    // Nenalezeno
                    Console.WriteLine("Nebyly nalezeny žádné záznamy.");
                    
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");

            // konečná hláška
            Console.WriteLine("");
            Console.WriteLine("Libovolnou klávesou se vraťe do menu voleb");
        }
        public void VypisVsechnyZaznamy()
        {
            List<Zaznam> zaznamy = databaze.VsechnyZaznamy();
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine
                    ("Nalezeny tyto záznamy:\n" +
                     "|          Jméno|       Příjmení|      Telefon|Věk|\n" +
                     "___________________________________________________");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
                
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
                Console.WriteLine("");
                Console.WriteLine("Libovolnou klávesou se vraťe do menu voleb");

        }
    }
}
