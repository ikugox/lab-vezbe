using System;
using System.Collections.Generic;
using System.Linq;

namespace OOProjektovanje.Podaci
{
    public class ListaDozvola
    {
        #region Atributes

        private List<Dozvola> _listaDozvola;

        #endregion

        #region Properties
        
        public List<Dozvola> ListaDozvolaValues
        {
            get
            {
                return _listaDozvola;
            }
        }

        #endregion

        #region Constructors

        public ListaDozvola()
        {
            _listaDozvola = new List<Dozvola>();
        }


        #endregion

        #region Methods

        public bool DodajDozvolu(Dozvola o)
        {
            if (PostojiDozvolaUListi(o))
                return false;

            _listaDozvola.Add(o);
            return true;
        }

        public bool ObrisiDozvolu(Dozvola o)
        {
            if (!PostojiDozvolaUListi(o))
                return false;

            _listaDozvola.Remove(o);
            return true;
        }

        public Dozvola GetDozvola(int index)
        {
            return _listaDozvola.ElementAt(index);
        }

        public bool PostojiDozvolaUListi(Dozvola o)
        {
            foreach (var v in _listaDozvola)
            {
                if (v.DatumDo == o.DatumDo && v.Kategorija == o.Kategorija)
                    return true;
            }

            return false;
        }

        //public Dozvola GetDozvola(String brvd)
        //{
        //    foreach (var v in _listaDozvola)
        //    {
        //        if (v.BrVozacke == brvd)
        //            return v;
        //    }
        //
        //    return null;
        //}

        #endregion
    }
}

