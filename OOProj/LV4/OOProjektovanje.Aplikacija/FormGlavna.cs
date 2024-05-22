using OOProjektovanje.Podaci;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OOProjektovanje.Aplikacija
{
    public partial class FormGlavna : Form
    {
        #region Constructors

        public FormGlavna()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li ste sigurni da izvrsite izabranu akciju?",
                                   "Obavestenje",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
        }

        void UcitajPodatke()
        {
            dgvListaVozaca.DataSource = ListaOsoba.Instance.ListaOsobaValues.ToList();
            dgvListaVozaca.Columns["DatumRodjenja"].Visible = false;
            dgvListaVozaca.Columns["VazenjeOd"].Visible = false;
            dgvListaVozaca.Columns["VazenjeDo"].Visible = false;
            dgvListaVozaca.Columns["MestoIzdavanja"].Visible = false;
            dgvListaVozaca.Columns["Pol"].Visible = false;
            dgvListaVozaca.Columns["FilePathSlike"].Visible = false;


            if (dgvListaVozaca.RowCount > 0)
            {
                btnObrisi.Visible = true;
                btnIzmeni.Visible = true;
            }
            else
            {
                btnObrisi.Visible = false;
                btnIzmeni.Visible = false;
            }
        }

        #endregion

        #region EventHandlers

        private void FormGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.No)
                e.Cancel = true;
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            btnObrisi.Visible = false;
            btnIzmeni.Visible = false;
            lblTacnoVreme.Text = string.Empty;

            tmrTacnoVReme.Start();

            UcitajPodatke();
        }

        private void tmrTacnoVReme_Tick(object sender, EventArgs e)
        {
            string str = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
            lblTacnoVreme.Text = str;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frm = new FormVozac();
            //frm.Show();
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brvd = (string)dgvListaVozaca["BrVozacke", selectedRow].Value;

            var o = ListaOsoba.Instance.GetOsoba(brvd);

            var frm = new FormVozac();
            frm.Vozac = o;

            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brvd = (string)dgvListaVozaca["BrVozacke", selectedRow].Value;

            var o = ListaOsoba.Instance.GetOsoba(brvd);

            if (ListaOsoba.Instance.ObrisiOsobu(o))
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

        #endregion

        private void cmbSortiranje_IndexChange(object sender, EventArgs e)
        {
            if (cmbSortiranje.SelectedIndex == -1)
                return;
            if (cmbSortiranje.SelectedIndex == 0)
                ListaOsoba.Instance.SortListDelegate = ListaOsoba.SortBRVD;
            else if (cmbSortiranje.SelectedIndex == 1)
                ListaOsoba.Instance.SortListDelegate = ListaOsoba.SortIme;
            else //if (cmbSortiranje.SelectedIndex == 2)
                ListaOsoba.Instance.SortListDelegate = ListaOsoba.SortPrezime;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //ListaOsoba.Instance.SortListDelegate(ListaOsoba.Instance.ListaOsobaValues);
            ListaOsoba.Instance.SortListValue();
            UcitajPodatke();
        }
    }
}
