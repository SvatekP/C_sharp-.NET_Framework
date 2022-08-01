namespace Zapocet_SvatekP
{
    partial class Rezervace
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
            this.dgvTerminy = new System.Windows.Forms.DataGridView();
            this.SportRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CisloHristeRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPotvrdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZrusit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSportFiltr = new System.Windows.Forms.TextBox();
            this.tbDenFiltr = new System.Windows.Forms.TextBox();
            this.btnFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTerminy
            // 
            this.dgvTerminy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SportRez,
            this.CisloHristeRez,
            this.CenaRez,
            this.DenRez,
            this.CasRez});
            this.dgvTerminy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTerminy.Location = new System.Drawing.Point(12, 59);
            this.dgvTerminy.Name = "dgvTerminy";
            this.dgvTerminy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerminy.Size = new System.Drawing.Size(717, 256);
            this.dgvTerminy.TabIndex = 4;
            // 
            // SportRez
            // 
            this.SportRez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SportRez.DataPropertyName = "Sport";
            this.SportRez.HeaderText = "Sport";
            this.SportRez.Name = "SportRez";
            this.SportRez.Width = 57;
            // 
            // CisloHristeRez
            // 
            this.CisloHristeRez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CisloHristeRez.DataPropertyName = "CisloHriste";
            this.CisloHristeRez.HeaderText = "Číslo hřiště";
            this.CisloHristeRez.Name = "CisloHristeRez";
            this.CisloHristeRez.Width = 85;
            // 
            // CenaRez
            // 
            this.CenaRez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CenaRez.DataPropertyName = "Cena";
            this.CenaRez.HeaderText = "Cena";
            this.CenaRez.Name = "CenaRez";
            this.CenaRez.Width = 57;
            // 
            // DenRez
            // 
            this.DenRez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DenRez.DataPropertyName = "Den";
            this.DenRez.HeaderText = "Den";
            this.DenRez.Name = "DenRez";
            this.DenRez.Width = 52;
            // 
            // CasRez
            // 
            this.CasRez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CasRez.DataPropertyName = "Cas";
            this.CasRez.HeaderText = "Čas";
            this.CasRez.Name = "CasRez";
            this.CasRez.Width = 50;
            // 
            // btnPotvrdit
            // 
            this.btnPotvrdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPotvrdit.Location = new System.Drawing.Point(283, 321);
            this.btnPotvrdit.Name = "btnPotvrdit";
            this.btnPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdit.TabIndex = 5;
            this.btnPotvrdit.Text = "Potvrdit";
            this.btnPotvrdit.UseVisualStyleBackColor = true;
            this.btnPotvrdit.Click += new System.EventHandler(this.btnPotvrdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Volné termíny:";
            // 
            // btnZrusit
            // 
            this.btnZrusit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZrusit.Location = new System.Drawing.Point(364, 321);
            this.btnZrusit.Name = "btnZrusit";
            this.btnZrusit.Size = new System.Drawing.Size(75, 23);
            this.btnZrusit.TabIndex = 7;
            this.btnZrusit.Text = "Zrušit";
            this.btnZrusit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Den:";
            // 
            // tbSportFiltr
            // 
            this.tbSportFiltr.Location = new System.Drawing.Point(53, 6);
            this.tbSportFiltr.Name = "tbSportFiltr";
            this.tbSportFiltr.Size = new System.Drawing.Size(144, 20);
            this.tbSportFiltr.TabIndex = 10;
            // 
            // tbDenFiltr
            // 
            this.tbDenFiltr.Location = new System.Drawing.Point(239, 6);
            this.tbDenFiltr.Name = "tbDenFiltr";
            this.tbDenFiltr.Size = new System.Drawing.Size(144, 20);
            this.tbDenFiltr.TabIndex = 11;
            // 
            // btnFiltr
            // 
            this.btnFiltr.Location = new System.Drawing.Point(389, 4);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnFiltr.TabIndex = 12;
            this.btnFiltr.Text = "Filtrovat";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // Rezervace
            // 
            this.AcceptButton = this.btnPotvrdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZrusit;
            this.ClientSize = new System.Drawing.Size(745, 352);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.tbDenFiltr);
            this.Controls.Add(this.tbSportFiltr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZrusit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotvrdit);
            this.Controls.Add(this.dgvTerminy);
            this.MaximizeBox = false;
            this.Name = "Rezervace";
            this.ShowIcon = false;
            this.Text = "Rezervovat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTerminy;
        private System.Windows.Forms.Button btnPotvrdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZrusit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn CisloHristeRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasRez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSportFiltr;
        private System.Windows.Forms.TextBox tbDenFiltr;
        private System.Windows.Forms.Button btnFiltr;
    }
}