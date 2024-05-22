enum KvalitetJela {
    Prihvatljiv = 1,
    Dobar,
    Odlican
}

class Jelo : Stavka {
    private float _nabavnaCena;
    private KvalitetJela _kvalitet;
    
    public Jelo(string _naziv, DateTime _istekRoka, bool _veganska,
                float _nabavnaCena, KvalitetJela _kvalitet)
            : base(_naziv, _istekRoka, _veganska) {
        this._nabavnaCena = _nabavnaCena;
        this._kvalitet = _kvalitet;
    }
    public Jelo() : base() {}
/* -------------------------------------------------------------------------- */
    public override float VratiCenu() {
        float cena = _nabavnaCena * (int)_kvalitet;
        if ((_istekRoka - DateTime.Today).Days <= 3)
            cena *= 0.8f;
        return cena;
    }

    public override void Upisi(BinaryWriter bw) {
        bw.Write('j');
        bw.Write(_nabavnaCena);
        bw.Write((int)_kvalitet);
        base.Upisi(bw);
    }

    public override void Ucitaj(BinaryReader br) {
        _nabavnaCena = br.ReadSingle();
        _kvalitet = (KvalitetJela)br.ReadInt32();
        base.Ucitaj(br);
    }
/* -------------------------------------------------------------------------- */
    public override void Print() {
        base.Print();
        Console.WriteLine("NabavnaCena: " + _nabavnaCena);
        Console.WriteLine("Kvalitet: " + _kvalitet);
    }
}