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
    public partial class Form1 : Form
    {
        NovyZakaznik novyZakaznikDialog = new NovyZakaznik();
        public Zakaznik aktualniZakaznik;
        public Form1()
        {
            InitializeComponent();
            dgvZakaznici.DataSource = Databaze.Zakaznici;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnNovy_Click(object sender, EventArgs e)
        {
            novyZakaznikDialog.Akce = TypAkce.Novy;
            if (novyZakaznikDialog.ShowDialog() == DialogResult.OK)
                Databaze.Zakaznici.Add(novyZakaznikDialog.AktualniZakaznik);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            novyZakaznikDialog.Akce = TypAkce.Edit;
            novyZakaznikDialog.AktualniZakaznik = (Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem;
            novyZakaznikDialog.ShowDialog();
        }

        private void dgvZakaznici_SelectionChanged(object sender, EventArgs e)
        {
            dgvRezervace.DataSource = ((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem).Rezervovane;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Databaze.Serializuj();
        }

        private void btnRezervovat_Click(object sender, EventArgs e)
        {
            Rezervace rezervovatTermin = new Rezervace((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem);
            rezervovatTermin.ShowDialog();
        }

        private void btnZrusitRezervaci_Click(object sender, EventArgs e)
        {
            Databaze.ZrusitRezervaci((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem, dgvRezervace.SelectedRows);
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            Databaze.SmazatZakaznika((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem);
        }
    }
}
