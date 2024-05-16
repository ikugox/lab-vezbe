namespace OOProjektovanje.Aplikacija
{
    partial class FormGlavna
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
            this.components = new System.ComponentModel.Container();
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.lblTacnoVreme = new System.Windows.Forms.Label();
            this.tmrTacnoVReme = new System.Windows.Forms.Timer(this.components);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaOsobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formGlavnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaOsobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formGlavnaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVozaca
            // 
            this.dgvListaVozaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaVozaca.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.Location = new System.Drawing.Point(6, 19);
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.Size = new System.Drawing.Size(476, 170);
            this.dgvListaVozaca.TabIndex = 0;
            // 
            // lblTacnoVreme
            // 
            this.lblTacnoVreme.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacnoVreme.Location = new System.Drawing.Point(12, 9);
            this.lblTacnoVreme.Name = "lblTacnoVreme";
            this.lblTacnoVreme.Size = new System.Drawing.Size(210, 22);
            this.lblTacnoVreme.TabIndex = 0;
            this.lblTacnoVreme.Text = "HH:mm:ss dd.MM.yyyy.";
            // 
            // tmrTacnoVReme
            // 
            this.tmrTacnoVReme.Interval = 1000;
            this.tmrTacnoVReme.Tick += new System.EventHandler(this.tmrTacnoVReme_Tick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.cleanAll;
            this.btnObrisi.Location = new System.Drawing.Point(395, 239);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 38);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.edit;
            this.btnIzmeni.Location = new System.Drawing.Point(123, 239);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(105, 38);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::OOProjektovanje.Aplikacija.Properties.Resources.add;
            this.btnDodaj.Location = new System.Drawing.Point(12, 239);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 38);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaVozaca);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista vozaca";
            // 
            // listaOsobaBindingSource
            // 
            this.listaOsobaBindingSource.DataSource = typeof(OOProjektovanje.Podaci.ListaOsoba);
            // 
            // formGlavnaBindingSource
            // 
            this.formGlavnaBindingSource.DataSource = typeof(OOProjektovanje.Aplikacija.FormGlavna);
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.cmbSortiranje.Location = new System.Drawing.Point(379, 12);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(121, 21);
            this.cmbSortiranje.TabIndex = 2;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_IndexChange);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(295, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(78, 21);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // FormGlavna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 283);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGlavna_FormClosing);
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaOsobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formGlavnaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVozaca;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblTacnoVreme;
        private System.Windows.Forms.Timer tmrTacnoVReme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource listaOsobaBindingSource;
        private System.Windows.Forms.BindingSource formGlavnaBindingSource;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.Button btnSort;
    }
}

