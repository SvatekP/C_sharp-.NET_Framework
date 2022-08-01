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
    public partial class Rezervace : Form
    {
        private Zakaznik _zakaznik;
        public Rezervace(Zakaznik zakaznik)
        {
            InitializeComponent();
            dgvTerminy.DataSource = Databaze.Terminy;
            _zakaznik = zakaznik;
        }

        private void btnPotvrdit_Click(object sender, EventArgs e)
        {
            Databaze.Rezervovat(_zakaznik, dgvTerminy.SelectedRows);
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            BindingList<Termin> TerminyFiltrovane = new BindingList<Termin>(Databaze.Terminy.Where(t => t.Sport.Contains(tbSportFiltr.Text) && t.Den.Contains(tbDenFiltr.Text)).ToList());
            dgvTerminy.DataSource = TerminyFiltrovane;
        }        
    }
}
