namespace Zapocet_SvatekP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovy = new System.Windows.Forms.Button();
            this.btnRezervovat = new System.Windows.Forms.Button();
            this.btnZrusitRezervaci = new System.Windows.Forms.Button();
            this.dgvZakaznici = new System.Windows.Forms.DataGridView();
            this.dgvRezervace = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CisloHriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Den = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.Jmeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RokNarozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCislo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervace)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovy
            // 
            this.btnNovy.Location = new System.Drawing.Point(15, 181);
            this.btnNovy.Name = "btnNovy";
            this.btnNovy.Size = new System.Drawing.Size(125, 23);
            this.btnNovy.TabIndex = 0;
            this.btnNovy.Text = "Nový Zákazník";
            this.btnNovy.UseVisualStyleBackColor = true;
            this.btnNovy.Click += new System.EventHandler(this.btnNovy_Click);
            // 
            // btnRezervovat
            // 
            this.btnRezervovat.Location = new System.Drawing.Point(644, 59);
            this.btnRezervovat.Name = "btnRezervovat";
            this.btnRezervovat.Size = new System.Drawing.Size(125, 70);
            this.btnRezervovat.TabIndex = 2;
            this.btnRezervovat.Text = "Rezervovat hřiště";
            this.btnRezervovat.UseVisualStyleBackColor = true;
            this.btnRezervovat.Click += new System.EventHandler(this.btnRezervovat_Click);
            // 
            // btnZrusitRezervaci
            // 
            this.btnZrusitRezervaci.Location = new System.Drawing.Point(644, 327);
            this.btnZrusitRezervaci.Name = "btnZrusitRezervaci";
            this.btnZrusitRezervaci.Size = new System.Drawing.Size(125, 70);
            this.btnZrusitRezervaci.TabIndex = 3;
            this.btnZrusitRezervaci.Text = "Zrušit Rezervaci";
            this.btnZrusitRezervaci.UseVisualStyleBackColor = true;
            this.btnZrusitRezervaci.Click += new System.EventHandler(this.btnZrusitRezervaci_Click);
            // 
            // dgvZakaznici
            // 
            this.dgvZakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaznici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jmeno,
            this.Prijmeni,
            this.RokNarozeni,
            this.Email,
            this.TelCislo});
            this.dgvZakaznici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvZakaznici.Location = new System.Drawing.Point(15, 25);
            this.dgvZakaznici.MultiSelect = false;
            this.dgvZakaznici.Name = "dgvZakaznici";
            this.dgvZakaznici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZakaznici.Size = new System.Drawing.Size(604, 150);
            this.dgvZakaznici.TabIndex = 4;
            this.dgvZakaznici.SelectionChanged += new System.EventHandler(this.dgvZakaznici_SelectionChanged);
            // 
            // dgvRezervace
            // 
            this.dgvRezervace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sport,
            this.CisloHriste,
            this.Cena,
            this.Den,
            this.Cas});
            this.dgvRezervace.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRezervace.Location = new System.Drawing.Point(15, 288);
            this.dgvRezervace.Name = "dgvRezervace";
            this.dgvRezervace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervace.Size = new System.Drawing.Size(607, 150);
            this.dgvRezervace.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seznam zákazníků:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seznam všech rezervací:\r\n";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 181);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Editovat Zákazníka";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Sport
            // 
            this.Sport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sport.DataPropertyName = "Sport";
            this.Sport.HeaderText = "Sport";
            this.Sport.Name = "Sport";
            this.Sport.Width = 57;
            // 
            // CisloHriste
            // 
            this.CisloHriste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CisloHriste.DataPropertyName = "CisloHriste";
            this.CisloHriste.HeaderText = "Číslo hřiště";
            this.CisloHriste.Name = "CisloHriste";
            this.CisloHriste.Width = 85;
            // 
            // Cena
            // 
            this.Cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cena.DataPropertyName = "Cena";
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.Width = 57;
            // 
            // Den
            // 
            this.Den.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Den.DataPropertyName = "Den";
            this.Den.HeaderText = "Den";
            this.Den.Name = "Den";
            this.Den.Width = 52;
            // 
            // Cas
            // 
            this.Cas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cas.DataPropertyName = "Cas";
            this.Cas.HeaderText = "Čas";
            this.Cas.Name = "Cas";
            this.Cas.Width = 50;
            // 
            // btnSmazat
            // 
            this.btnSmazat.Location = new System.Drawing.Point(277, 181);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(125, 23);
            this.btnSmazat.TabIndex = 9;
            this.btnSmazat.Text = "Smazat Zákazníka";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // Jmeno
            // 
            this.Jmeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Jmeno.DataPropertyName = "Jmeno";
            this.Jmeno.HeaderText = "Jméno";
            this.Jmeno.Name = "Jmeno";
            this.Jmeno.Width = 63;
            // 
            // Prijmeni
            // 
            this.Prijmeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prijmeni.DataPropertyName = "Prijmeni";
            this.Prijmeni.HeaderText = "Příjmení";
            this.Prijmeni.Name = "Prijmeni";
            this.Prijmeni.Width = 73;
            // 
            // RokNarozeni
            // 
            this.RokNarozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RokNarozeni.DataPropertyName = "RokNarozeni";
            this.RokNarozeni.HeaderText = "Rok narození";
            this.RokNarozeni.MinimumWidth = 100;
            this.RokNarozeni.Name = "RokNarozeni";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // TelCislo
            // 
            this.TelCislo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TelCislo.DataPropertyName = "TelCislo";
            this.TelCislo.HeaderText = "Telefonní číslo";
            this.TelCislo.MinimumWidth = 110;
            this.TelCislo.Name = "TelCislo";
            this.TelCislo.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmazat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRezervace);
            this.Controls.Add(this.dgvZakaznici);
            this.Controls.Add(this.btnZrusitRezervaci);
            this.Controls.Add(this.btnRezervovat);
            this.Controls.Add(this.btnNovy);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Rezervační systém";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovy;
        private System.Windows.Forms.Button btnRezervovat;
        private System.Windows.Forms.Button btnZrusitRezervaci;
        private System.Windows.Forms.DataGridView dgvRezervace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.DataGridView dgvZakaznici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn CisloHriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Den;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cas;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jmeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijmeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn RokNarozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCislo;
    }
}

