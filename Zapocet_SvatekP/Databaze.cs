using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zapocet_SvatekP
{
    public static class Databaze
    {
        public static BindingList<Zakaznik> Zakaznici { get; private set; } = new BindingList<Zakaznik>();
        public static BindingList<Termin> Terminy { get; private set; } = new BindingList<Termin>();
        static Databaze()
        {            
            Deserializuj();
        }
        public static void Serializuj()
        {
            Serializuj(Zakaznici, "zakaznici.bin");
            Serializuj(Terminy, "terminy.bin");
        }

        public static void Serializuj<T>(BindingList<T> list, string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Create))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, list);
            }
        }

        public static void Deserializuj()
        {
            Zakaznici = Deserializuj<Zakaznik>("zakaznici.bin");
            Terminy = Deserializuj<Termin>("terminy.bin");
        }

        public static BindingList<T> Deserializuj<T>(string soubor)
        {
            using (Stream str = File.Open(soubor, FileMode.Open))
            {
                BinaryFormatter binf = new BinaryFormatter();
                return (BindingList<T>)binf.Deserialize(str);
            }
        }
        public static void Rezervovat(Zakaznik zakaznik, DataGridViewSelectedRowCollection radkyTerminu)
        {
            foreach (DataGridViewRow radek in radkyTerminu)
            {
                Termin termin = (Termin)(radek.DataBoundItem);

                zakaznik.Rezervovane.Add(termin);
                Terminy.Remove(termin);
            }
        }

        public static void ZrusitRezervaci(Zakaznik zakaznik, DataGridViewSelectedRowCollection radkyTerminu)
        {
            foreach (DataGridViewRow radek in radkyTerminu)
            {
                Termin termin = (Termin)(radek.DataBoundItem);

                zakaznik.Rezervovane.Remove(termin);
                Terminy.Add(termin);
            }
        }

        public static void SmazatZakaznika(Zakaznik zakaznik)
        {
            Zakaznici.Remove(zakaznik);
        }
    }
}
