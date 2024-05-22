using OOProjektovanje.Extensions;
using OOProjektovanje.Podaci;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOProjektovanje.Aplikacija
{
    public partial class FormVozac : Form
    {
        #region Properties
        
        public Osoba Vozac { get; set; }
        public ListaDozvola listaKategorijaLocal = new ListaDozvola();
        public ListaDozvola listaZabranaLocal = new ListaDozvola();
        #endregion

        #region Constructors

        public FormVozac()
        {
            InitializeComponent();
        }

        public FormVozac(Osoba o)
            : this()
        {           
            Vozac = o;
            btnProsledi.Text = "Izmeni";
        }

        #endregion

        #region Methods

        bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Polje Prezime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }

            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Polje Vazenje dozvole od ne sme biti manje od od.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            
            if ((DateTime.Today - dtpRodjenje.Value.Date).TotalDays < 6574.5)
            {
                MessageBox.Show("Korisnik ne moze da bude mladji od 18 godina.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            
            if (txtBRVD.Text.Length < 9)
            {
                MessageBox.Show("Polje Br. vozacke dozvole mora sadrzati 9 cifara.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (string.IsNullOrEmpty(txtMesto.Text))
            {
                MessageBox.Show("Polje Mesto izdavanja ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(cmbPol.Text))
            {
                MessageBox.Show("Polje Pol ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }

            if (pbSlika.Image == null)
            {
                MessageBox.Show("Nije izabrana slika.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        void UcitajPodatkeUKontrole()
        {
            txtIme.Text = Vozac.Ime;
            txtPrezime.Text = Vozac.Prezime;
            dtpRodjenje.Value = Vozac.DatumRodjenja;
            dtpOd.Value = Vozac.VazenjeOd;
            dtpDo.Value = Vozac.VazenjeDo;
            txtBRVD.Text = Vozac.BrVozacke;
            txtMesto.Text = Vozac.MestoIzdavanja;
            cmbPol.Text = Vozac.Pol;
            pbSlika.ImageLocation = Vozac.FilePathSlike;
            //dgvKategorija.DataSource = listaKategorijaLocal.ListaDozvolaValues;
            //dgvZabrana.DataSource = Vozac.listaZabrana.ListaDozvolaValues;
            
            // zabranjujemo izmenu maticnog broja pri editovanju
            txtBRVD.Enabled = false;
            btnProsledi.Text = "Izmeni";
        }

        bool Dodaj()
        {
            var o = new Osoba
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodjenja = dtpRodjenje.Value,
                VazenjeOd = dtpOd.Value,
                VazenjeDo = dtpDo.Value,
                BrVozacke = txtBRVD.Text,
                MestoIzdavanja = txtMesto.Text,
                Pol = cmbPol.Text,
                FilePathSlike = imagePathHelper,
                listaKategorija = new ListaDozvola(),
                listaZabrana = new ListaDozvola(),
            };
            foreach (var x in listaKategorijaLocal.ListaDozvolaValues)
            {
                o.listaKategorija.DodajDozvolu(x);
            }
            foreach (var x in listaZabranaLocal.ListaDozvolaValues)
            {
                o.listaZabrana.DodajDozvolu(x);
            }

            return ListaOsoba.Instance.DodajOsobu(o);
        }

        bool Izmeni()
        {
            var o = new Osoba
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodjenja = dtpRodjenje.Value,
                VazenjeOd = dtpOd.Value,
                VazenjeDo = dtpDo.Value,
                BrVozacke = txtBRVD.Text,
                MestoIzdavanja = txtMesto.Text,
                Pol = cmbPol.Text,
                FilePathSlike = pbSlika.ImageLocation,
                listaKategorija = listaKategorijaLocal,
                listaZabrana = listaZabranaLocal
            };

            return ListaOsoba.Instance.IzmeniOsobu(o);
        }

        #endregion

        #region EventsHandler

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            if (Vozac == null) // ukoliko je Vozac null dodajemo novog Vozaca, u suprotnom vrsimo azuriranje prosledjenog Vozaca
            {
                if (!Dodaj())
                {
                    MessageBox.Show("Neuspesno dodavanje. Pokusajte ponovo.",
                                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Focus();

                    return;
                }
            }
            else
            {

                if (!Izmeni())
                {
                    MessageBox.Show("Neuspesna izmena. Pokusajte ponovo.",
                                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Focus();

                    return;
                }
            }

            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBRVD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtIme.Text = txtIme.Text.PostaviPrvoVelikoSlovo();
            txtPrezime.Text = txtPrezime.Text.PostaviPrvoVelikoSlovo();
            txtMesto.Text = txtMesto.Text.PostaviPrvoVelikoSlovo();
        }
        
        private void FormVozac_Load(object sender, EventArgs e)
        {
            if (Vozac != null)
                UcitajPodatkeUKontrole();
            UcitajPodatke();
        }

        #endregion

        void UcitajPodatke()
        {
            //dgvKategorija.DataSource = ListaDozvolaKategorija.Instance.ListaDozvolaValues.ToList();
            //dgvZabrana.DataSource = ListaDozvolaZabrana.Instance.ListaDozvolaValues.ToList();
            if (Vozac != null)
            {
                listaKategorijaLocal = Vozac.listaKategorija;
                listaZabranaLocal = Vozac.listaZabrana;
            }

            dgvKategorija.DataSource = listaKategorijaLocal.ListaDozvolaValues.ToList();
            dgvZabrana.DataSource = listaZabranaLocal.ListaDozvolaValues.ToList();

            if (pbSlika.ImageLocation != null)
                pbSlika.Image = Image.FromFile(pbSlika.ImageLocation);
        }

        private void btnDodajKategorija_Click(object sender, EventArgs e)
        {
            var frm = new FormVozacKategorija(ref listaKategorijaLocal);
            //frm.Show();

            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnDodajZabrana_Click(object sender, EventArgs e)
        {
            var frm = new FormVozacZabrana(ref listaZabranaLocal, ref listaKategorijaLocal);
            //frm.Show();

            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisiKategorija_Click(object sender, EventArgs e)
        {
            if (dgvKategorija.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvKategorija.SelectedRows[0].Index;
            var d = listaKategorijaLocal.GetDozvola(selectedRow);


            if (listaKategorijaLocal.ObrisiDozvolu(d))
            {
                MessageBox.Show("Izabrana akcija je uspesno obavljena.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspesno obavljena. Pokusajte ponovo.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            UcitajPodatke();
        }
        
        private void btnObrisiZabrana_Click(object sender, EventArgs e)
        {
            if (dgvZabrana.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvZabrana.SelectedRows[0].Index;
            var d = listaZabranaLocal.GetDozvola(selectedRow);

            if (listaZabranaLocal.ObrisiDozvolu(d))
            {
                MessageBox.Show("Izabrana akcija je uspesno obavljena.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspesno obavljena. Pokusajte ponovo.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            UcitajPodatke();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            string filePath = opf.FileName;
            if (filePath != "")
                pbSlika.Image = Image.FromFile(filePath);
            imagePathHelper = filePath;
        }

        private string imagePathHelper;
    }
}
