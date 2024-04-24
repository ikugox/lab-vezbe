class VeganUnfriendly : Exception {
    public string error = "Nije veganski restoran";
}

class Restoran {
    private string _naziv = "";
    private List<Stavka> _meni = new();

    public Restoran(string _naziv) {
        this._naziv = _naziv;
    }
/* -------------------------------------------------------------------------- */
    public void DodajStavku(Stavka obj) {
        _meni.Add(obj);
    }

    public void Sortitaj() {
        _meni.Sort();
    }

    public void IzbaciPokvareno() {
        foreach (Stavka stavka in _meni.ToList())
            if (stavka.IstekRoka < DateTime.Today)
                _meni.Remove(stavka);
    }

    public void VeganProvera() {
        bool jeVegan = false;
        foreach (Stavka stavka in _meni)
            if (stavka.Veganska) {
                jeVegan = true;
                break;
            }
        if (!jeVegan)
            throw new VeganUnfriendly();
    }

    public void Upisi(string bwName) {
        using BinaryWriter bw = new(new FileStream(bwName, FileMode.Create));
        bw.Write(_naziv);
        bw.Write(_meni.Count);
        foreach (Stavka stavka in _meni)
            stavka.Upisi(bw);
    }

    public void Ucitaj(string brName) {
        using BinaryReader br = new(new FileStream(brName, FileMode.Open));
        _naziv = br.ReadString();
        int brojStavki = br.ReadInt32();
        for (int i = 0; i < brojStavki; i++) {
            char tipStavke = br.ReadChar();
            Stavka s;
            if (tipStavke == 'j')
                s = new Jelo();
            else if (tipStavke == 'p')
                s = new Pice();
            else
                throw new InvalidDataException("Tip stavke nije podrzan");
            s.Ucitaj(br);
            _meni.Add(s);
        }
    }
/* -------------------------------------------------------------------------- */
    public void Print() {
        Console.WriteLine("Ime: " + _naziv);
        Console.WriteLine("--------MENI--------");
        foreach (Stavka stavka in _meni)
            stavka.Print();
    }
}