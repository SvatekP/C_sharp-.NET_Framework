namespace Zapocet_SvatekP
{
    partial class NovyZakaznik
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnZrusit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBJmeno = new System.Windows.Forms.TextBox();
            this.tBPrijmeni = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBTelefon = new System.Windows.Forms.TextBox();
            this.nUDRok = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(15, 229);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnZrusit
            // 
            this.btnZrusit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZrusit.Location = new System.Drawing.Point(179, 229);
            this.btnZrusit.Name = "btnZrusit";
            this.btnZrusit.Size = new System.Drawing.Size(75, 23);
            this.btnZrusit.TabIndex = 2;
            this.btnZrusit.Text = "Zrušit";
            this.btnZrusit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Příjmení:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rok narození:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tel. číslo:";
            // 
            // tBJmeno
            // 
            this.tBJmeno.Location = new System.Drawing.Point(89, 24);
            this.tBJmeno.Name = "tBJmeno";
            this.tBJmeno.Size = new System.Drawing.Size(165, 20);
            this.tBJmeno.TabIndex = 7;
            // 
            // tBPrijmeni
            // 
            this.tBPrijmeni.Location = new System.Drawing.Point(89, 69);
            this.tBPrijmeni.Name = "tBPrijmeni";
            this.tBPrijmeni.Size = new System.Drawing.Size(165, 20);
            this.tBPrijmeni.TabIndex = 8;
            // 
            // tBEmail
            // 
            this.tBEmail.Location = new System.Drawing.Point(89, 149);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(165, 20);
            this.tBEmail.TabIndex = 10;
            // 
            // tBTelefon
            // 
            this.tBTelefon.Location = new System.Drawing.Point(89, 185);
            this.tBTelefon.Name = "tBTelefon";
            this.tBTelefon.Size = new System.Drawing.Size(165, 20);
            this.tBTelefon.TabIndex = 11;
            // 
            // nUDRok
            // 
            this.nUDRok.Location = new System.Drawing.Point(93, 117);
            this.nUDRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nUDRok.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nUDRok.Name = "nUDRok";
            this.nUDRok.Size = new System.Drawing.Size(101, 20);
            this.nUDRok.TabIndex = 12;
            this.nUDRok.TabStop = false;
            this.nUDRok.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nUDRok.ValueChanged += new System.EventHandler(this.nUDRok_ValueChanged);
            // 
            // NovyZakaznik
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZrusit;
            this.ClientSize = new System.Drawing.Size(283, 262);
            this.Controls.Add(this.nUDRok);
            this.Controls.Add(this.tBTelefon);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.tBPrijmeni);
            this.Controls.Add(this.tBJmeno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZrusit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovyZakaznik";
            this.ShowIcon = false;
            this.Text = "Zákazník";
            this.VisibleChanged += new System.EventHandler(this.NovyZakaznik_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nUDRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnZrusit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBJmeno;
        private System.Windows.Forms.TextBox tBPrijmeni;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBTelefon;
        private System.Windows.Forms.NumericUpDown nUDRok;
    }
}