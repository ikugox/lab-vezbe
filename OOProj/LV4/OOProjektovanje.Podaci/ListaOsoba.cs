using System;
using System.Collections.Generic;

namespace OOProjektovanje.Podaci
{
    public class ListaOsoba
    {
        #region Atributes

        private List<Osoba> _listaOsoba;

        #endregion

        #region Properties
        public List<Osoba> ListaOsobaValues
        {
            get
            {
                return _listaOsoba;
            }
        }
        #endregion

        #region Constructors

        private ListaOsoba()
        {
            _listaOsoba = new List<Osoba>();
            SortListDelegate = ListaOsoba.SortIme;
        }

        #endregion

        #region Methods

        public bool DodajOsobu(Osoba o)
        {
            if (PostojiOsobaUListi(o))
                return false;

            _listaOsoba.Add(o);
            return true;
        }

        public bool IzmeniOsobu(Osoba o)
        {
            var tmp = GetOsoba(o.BrVozacke);

            if (tmp == null)
                return false;

            tmp.Ime = o.Ime;
            tmp.Prezime = o.Prezime;
            tmp.Pol = o.Pol;
            tmp.BrVozacke = o.BrVozacke;

            return true;
        }

        public bool ObrisiOsobu(Osoba o)
        {
            if (!PostojiOsobaUListi(o))
                return false;

            _listaOsoba.Remove(o);
            return true;
        }

        public bool ObrisiOsobu(String brvd)
        {
            Osoba tmpOsoba = null;

            foreach (var v in _listaOsoba)
            {
                if (v.BrVozacke == brvd)
                {
                    tmpOsoba = v;
                    break;
                }
            }

            if (tmpOsoba != null)
            {
                _listaOsoba.Remove(tmpOsoba);
                return true;
            }

            return false;
        }

        public bool PostojiOsobaUListi(Osoba o)
        {
            foreach (var v in _listaOsoba)
            {
                if (v.BrVozacke == o.BrVozacke)
                    return true;
            }

            return false;
        }

        public bool PostojiOsobaUListi(String brvd)
        {
            foreach (var v in _listaOsoba)
            {
                if (v.BrVozacke == brvd)
                    return true;
            }

            return false;
        }

        public Osoba GetOsoba(String brvd)
        {
            foreach (var v in _listaOsoba)
            {
                if (v.BrVozacke == brvd)
                    return v;
            }

            return null;
        }

        public void SortListValue()
        {
            if (SortListDelegate != null)
                SortListDelegate(_listaOsoba);
        }

        #endregion

        #region Instance

        private static ListaOsoba _instance = null;
        public static ListaOsoba Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaOsoba();

                return _instance;
            }
        }

        #endregion

        #region Sorting

        public delegate void SortDelegate(List<Osoba> o);
        public SortDelegate SortListDelegate { get; set; }

        public static void SortBRVD(List<Osoba> o)
        {
            o.Sort((a,b) => a.BrVozacke.CompareTo(b.BrVozacke));
        }
        public static void SortIme(List<Osoba> o)
        {
            o.Sort((a, b) => a.Ime.CompareTo(b.Ime));
        }
        public static void SortPrezime(List<Osoba> o)
        {
            o.Sort((a, b) => a.Prezime.CompareTo(b.Prezime));
        }

        #endregion
    }
}

