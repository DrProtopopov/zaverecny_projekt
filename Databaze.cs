using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAVERECNY_PROJEKT
{
    class Databaze
    {
        private List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejZaznam(string jmeno, string prijmeni, string tel, string vek)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, tel, vek));
        }
        public List<Zaznam> NajdiZaznamy(string jmeno, string prijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if (z.Jmeno == jmeno && z.Prijmeni == prijmeni)
                    nalezene.Add(z);
            }
            return nalezene;
        }
        public List<Zaznam> VsechnyZaznamy()
        {
            List<Zaznam> vsechny = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                
                    vsechny.Add(z);
            }
            return vsechny;
        }


    }
}
