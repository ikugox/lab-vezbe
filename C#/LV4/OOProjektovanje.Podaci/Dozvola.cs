using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OOProjektovanje.Podaci
{
    public class Dozvola : object
    {
        #region Properties and Atributes

        public string Kategorija { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }

        #endregion

        //   [Browsable(true)]
        //  [DisplayName("Za prikaz")]
        //public String ZaPrikaz
        //{
        //    get
        //    {
        //        return _ime + " " + _prezime + " JMBG:" + _jmbg;
        //    }
        //}
    }
}
