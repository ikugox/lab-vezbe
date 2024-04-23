class Pice : Stavka {
    private float _kolicina; 
    private float _cenaPoLitru; 
    private bool _domace; 

    public Pice(string _naziv, DateTime _istekRoka, bool _veganska,
                float _kolicina, float _cenaPoLitru, bool _domace)
            : base(_naziv, _istekRoka, _veganska) {
        this._kolicina = _kolicina;
        this._cenaPoLitru = _cenaPoLitru;
        this._domace = _domace;
    }
    public Pice() : base() {}
/* -------------------------------------------------------------------------- */

    public override float VratiCenu() {
        float cena = _cenaPoLitru * _kolicina;
        if (!_domace)
            cena *= 1.3f;
        return cena;
    }
    public override void Upisi(BinaryWriter bw) {
        bw.Write('p');
        bw.Write(_kolicina);
        bw.Write(_cenaPoLitru);
        bw.Write(_domace);
        base.Upisi(bw);
    }

    public override void Ucitaj(BinaryReader br) {
        _kolicina = br.ReadSingle();
        _cenaPoLitru = br.ReadSingle();
        _domace = br.ReadBoolean();
        base.Ucitaj(br);
    }
}