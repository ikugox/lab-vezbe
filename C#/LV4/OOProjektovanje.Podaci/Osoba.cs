using System;
using System.ComponentModel;

namespace OOProjektovanje.Podaci
{
    public class Osoba : Object
    {
        #region Properties and Atributes

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime VazenjeOd { get; set; }
        public DateTime VazenjeDo { get; set; }
        public string BrVozacke { get; set; }
        public string MestoIzdavanja { get; set; }
        public string Pol { get; set; }
        public string FilePathSlike { get; set; }
        public ListaDozvola listaKategorija { get; set; }
        public ListaDozvola listaZabrana { get; set; }

        public Osoba()
        {
            listaKategorija = new ListaDozvola();
            listaZabrana = new ListaDozvola();
        }
        #endregion
    }
}
