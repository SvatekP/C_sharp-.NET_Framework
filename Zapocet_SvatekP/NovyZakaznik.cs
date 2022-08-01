using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zapocet_SvatekP
{
    public enum TypAkce { Novy, Edit };
    public partial class NovyZakaznik : Form
    {
        public TypAkce Akce { get; set; } = TypAkce.Novy;
        public Zakaznik AktualniZakaznik { get; set; }
        public NovyZakaznik()
        {
            InitializeComponent();
        }

        private void NovyZakaznik_VisibleChanged(object sender, EventArgs e)
        {
            if (Akce == TypAkce.Edit)
            {
                tBJmeno.Text = AktualniZakaznik.Jmeno;
                tBPrijmeni.Text = AktualniZakaznik.Prijmeni;
                nUDRok.Value = AktualniZakaznik.RokNarozeni;
                tBEmail.Text = AktualniZakaznik.Email;
                tBTelefon.Text = AktualniZakaznik.TelCislo;
            }
            else
            {
                tBJmeno.Text = "";
                tBPrijmeni.Text = "";
                nUDRok.Value = 1950;
                tBEmail.Text = "";
                tBTelefon.Text = "";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (Akce)
            {
                case TypAkce.Novy:
                    AktualniZakaznik = new Zakaznik(tBJmeno.Text, tBPrijmeni.Text, (int)nUDRok.Value, tBEmail.Text, tBTelefon.Text);
                    break;
                case TypAkce.Edit:
                    AktualniZakaznik.Jmeno = tBJmeno.Text;
                    AktualniZakaznik.Prijmeni = tBPrijmeni.Text;
                    AktualniZakaznik.RokNarozeni = (int)nUDRok.Value;
                    AktualniZakaznik.Email = tBEmail.Text;
                    AktualniZakaznik.TelCislo = tBTelefon.Text;
                    break;
            }
        }

        private void nUDRok_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
