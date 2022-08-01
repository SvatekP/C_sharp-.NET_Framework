using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapocet_SvatekP
{
    [Serializable()]
    public class Termin
    {
        public string Sport { get; set; }
        public int CisloHriste { get; set; }
        public int Cena { get; set; }
        public string Den { get; set; }
        public string Cas { get; set; }

        public Termin(string sport, int cisloHriste, int cena, string den, string cas)
        {
            Sport = sport;
            CisloHriste = cisloHriste;
            Cena = cena;
            Den = den;
            Cas = cas;
        }
    }
}
