namespace OOProjektovanje.Aplikacija
{
    partial class FormVozac
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBRVD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpRodjenje = new System.Windows.Forms.DateTimePicker();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnDodajKategorija = new System.Windows.Forms.Button();
            this.btnObrisiKategorija = new System.Windows.Forms.Button();
            this.gbKategorija = new System.Windows.Forms.GroupBox();
            this.dgvKategorija = new System.Windows.Forms.DataGridView();
            this.gbZabrana = new System.Windows.Forms.GroupBox();
            this.dgvZabrana = new System.Windows.Forms.DataGridView();
            this.btnDodajZabrana = new System.Windows.Forms.Button();
            this.btnObrisiZabrana = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).BeginInit();
            this.gbZabrana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(84, 22);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(64, 48);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(86, 204);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(25, 13);
            this.lblPol.TabIndex = 14;
            this.lblPol.Text = "Pol:";
            // 
            // cmbPol
            // 
            this.cmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cmbPol.Location = new System.Drawing.Point(117, 201);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(100, 21);
            this.cmbPol.TabIndex = 15;
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(4, 152);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(107, 13);
            this.lblJmbg.TabIndex = 10;
            this.lblJmbg.Text = "Br. vozacke dozvole:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(117, 19);
            this.txtIme.MaxLength = 20;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(117, 45);
            this.txtPrezime.MaxLength = 20;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtBRVD
            // 
            this.txtBRVD.Location = new System.Drawing.Point(117, 149);
            this.txtBRVD.MaxLength = 13;
            this.txtBRVD.Name = "txtBRVD";
            this.txtBRVD.Size = new System.Drawing.Size(100, 20);
            this.txtBRVD.TabIndex = 11;
            this.txtBRVD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBRVD_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSlika);
            this.groupBox1.Controls.Add(this.pbSlika);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMesto);
            this.groupBox1.Controls.Add(this.dtpDo);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.dtpOd);
            this.groupBox1.Controls.Add(this.dtpRodjenje);
            this.groupBox1.Controls.Add(this.cmbPol);
            this.groupBox1.Controls.Add(this.lblJmbg);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.lblPol);
            this.groupBox1.Controls.Add(this.txtBRVD);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(238, 126);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(75, 23);
            this.btnSlika.TabIndex = 16;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(227, 19);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(100, 94);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 17;
            this.pbSlika.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mesto izdavanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum rodjenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vazenje dozvole od";
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(117, 175);
            this.txtMesto.MaxLength = 13;
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(100, 20);
            this.txtMesto.TabIndex = 13;
            this.txtMesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtMesto.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "dd. MM. yyyy.";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(117, 123);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(100, 20);
            this.dtpDo.TabIndex = 9;
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd. MM. yyyy.";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(117, 97);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(100, 20);
            this.dtpOd.TabIndex = 7;
            // 
            // dtpRodjenje
            // 
            this.dtpRodjenje.CustomFormat = "dd. MM. yyyy.";
            this.dtpRodjenje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRodjenje.Location = new System.Drawing.Point(117, 71);
            this.dtpRodjenje.Name = "dtpRodjenje";
            this.dtpRodjenje.Size = new System.Drawing.Size(100, 20);
            this.dtpRodjenje.TabIndex = 5;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(79, 585);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(198, 585);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnDodajKategorija
            // 
            this.btnDodajKategorija.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.add;
            this.btnDodajKategorija.Location = new System.Drawing.Point(6, 116);
            this.btnDodajKategorija.Name = "btnDodajKategorija";
            this.btnDodajKategorija.Size = new System.Drawing.Size(105, 38);
            this.btnDodajKategorija.TabIndex = 1;
            this.btnDodajKategorija.Text = "Dodaj novu kategoriju";
            this.btnDodajKategorija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKategorija.UseVisualStyleBackColor = true;
            this.btnDodajKategorija.Click += new System.EventHandler(this.btnDodajKategorija_Click);
            // 
            // btnObrisiKategorija
            // 
            this.btnObrisiKategorija.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.cleanAll;
            this.btnObrisiKategorija.Location = new System.Drawing.Point(227, 116);
            this.btnObrisiKategorija.Name = "btnObrisiKategorija";
            this.btnObrisiKategorija.Size = new System.Drawing.Size(105, 38);
            this.btnObrisiKategorija.TabIndex = 2;
            this.btnObrisiKategorija.Text = "Obrisi kategoriju";
            this.btnObrisiKategorija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKategorija.UseVisualStyleBackColor = true;
            this.btnObrisiKategorija.Click += new System.EventHandler(this.btnObrisiKategorija_Click);
            // 
            // gbKategorija
            // 
            this.gbKategorija.Controls.Add(this.dgvKategorija);
            this.gbKategorija.Controls.Add(this.btnDodajKategorija);
            this.gbKategorija.Controls.Add(this.btnObrisiKategorija);
            this.gbKategorija.Location = new System.Drawing.Point(12, 251);
            this.gbKategorija.Name = "gbKategorija";
            this.gbKategorija.Size = new System.Drawing.Size(338, 161);
            this.gbKategorija.TabIndex = 1;
            this.gbKategorija.TabStop = false;
            this.gbKategorija.Text = "Kategorija";
            // 
            // dgvKategorija
            // 
            this.dgvKategorija.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorija.Location = new System.Drawing.Point(6, 19);
            this.dgvKategorija.Name = "dgvKategorija";
            this.dgvKategorija.Size = new System.Drawing.Size(326, 91);
            this.dgvKategorija.TabIndex = 0;
            // 
            // gbZabrana
            // 
            this.gbZabrana.Controls.Add(this.dgvZabrana);
            this.gbZabrana.Controls.Add(this.btnDodajZabrana);
            this.gbZabrana.Controls.Add(this.btnObrisiZabrana);
            this.gbZabrana.Location = new System.Drawing.Point(12, 418);
            this.gbZabrana.Name = "gbZabrana";
            this.gbZabrana.Size = new System.Drawing.Size(338, 161);
            this.gbZabrana.TabIndex = 2;
            this.gbZabrana.TabStop = false;
            this.gbZabrana.Text = "Zabrana upravljanja";
            // 
            // dgvZabrana
            // 
            this.dgvZabrana.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZabrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrana.Location = new System.Drawing.Point(6, 19);
            this.dgvZabrana.Name = "dgvZabrana";
            this.dgvZabrana.Size = new System.Drawing.Size(326, 91);
            this.dgvZabrana.TabIndex = 0;
            // 
            // btnDodajZabrana
            // 
            this.btnDodajZabrana.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.add;
            this.btnDodajZabrana.Location = new System.Drawing.Point(6, 116);
            this.btnDodajZabrana.Name = "btnDodajZabrana";
            this.btnDodajZabrana.Size = new System.Drawing.Size(105, 38);
            this.btnDodajZabrana.TabIndex = 1;
            this.btnDodajZabrana.Text = "Dodaj novu zabranu";
            this.btnDodajZabrana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZabrana.UseVisualStyleBackColor = true;
            this.btnDodajZabrana.Click += new System.EventHandler(this.btnDodajZabrana_Click);
            // 
            // btnObrisiZabrana
            // 
            this.btnObrisiZabrana.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.cleanAll;
            this.btnObrisiZabrana.Location = new System.Drawing.Point(227, 116);
            this.btnObrisiZabrana.Name = "btnObrisiZabrana";
            this.btnObrisiZabrana.Size = new System.Drawing.Size(105, 38);
            this.btnObrisiZabrana.TabIndex = 2;
            this.btnObrisiZabrana.Text = "Obrisi zabranu";
            this.btnObrisiZabrana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiZabrana.UseVisualStyleBackColor = true;
            this.btnObrisiZabrana.Click += new System.EventHandler(this.btnObrisiZabrana_Click);
            // 
            // FormVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 613);
            this.Controls.Add(this.gbZabrana);
            this.Controls.Add(this.gbKategorija);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVozac";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.FormVozac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).EndInit();
            this.gbZabrana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtBRVD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DateTimePicker dtpRodjenje;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajKategorija;
        private System.Windows.Forms.Button btnObrisiKategorija;
        private System.Windows.Forms.GroupBox gbKategorija;
        private System.Windows.Forms.DataGridView dgvKategorija;
        private System.Windows.Forms.GroupBox gbZabrana;
        private System.Windows.Forms.DataGridView dgvZabrana;
        private System.Windows.Forms.Button btnDodajZabrana;
        private System.Windows.Forms.Button btnObrisiZabrana;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSlika;
    }
}