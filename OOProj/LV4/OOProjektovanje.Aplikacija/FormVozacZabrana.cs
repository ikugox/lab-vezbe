using OOProjektovanje.Extensions;
using OOProjektovanje.Podaci;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OOProjektovanje.Aplikacija
{
    public partial class FormVozacZabrana : Form
    {
        #region Constructors

        private ListaDozvola listaZabranaLocal { get; set; }


        public FormVozacZabrana()
        {
            InitializeComponent();
        }
        
        public FormVozacZabrana(ref ListaDozvola listaZabrana, ref ListaDozvola listaKategorija)
        {
            InitializeComponent();
            listaZabranaLocal = listaZabrana;
            cmbKategorija.DataSource = listaKategorija.ListaDozvolaValues.Select(d => d.Kategorija).ToList();
        }

        private void FormVozacZabrana_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        bool Validacija()
        {
            if (string.IsNullOrEmpty(cmbKategorija.Text))
            {
                MessageBox.Show("Polje Kategorija ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Polje Datum do ne sme biti manje od Datum od.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        bool Dodaj()
        {
            if (!Validacija())
                return false;

            var d = new Dozvola
            {
                Kategorija = cmbKategorija.Text,
                DatumOd = dtpOd.Value,
                DatumDo = dtpDo.Value
            };

            return listaZabranaLocal.DodajDozvolu(d);
        }

        #endregion

        #region EventsHandler

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Dodaj())
            {
                MessageBox.Show("Neuspesno dodavanje. Pokusajte ponovo.",
                                "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion
    }
}