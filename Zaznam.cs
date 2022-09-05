using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAVERECNY_PROJEKT
{
    class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Tel { get; set; }
        public string Vek { get; set; }

        public Zaznam (string jmeno, string prijmeni, string tel, string vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Tel = tel;
            Vek = vek;
        }
        public override string ToString()
        {
            return string.Format("|{0,15}|{1,15}|{2,13}|{3,3}|", Jmeno, Prijmeni, Tel, Vek);
            
        }
    }
}
