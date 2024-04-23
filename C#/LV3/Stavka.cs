abstract class Stavka : System.IComparable {
    protected string _naziv;
    protected DateTime _istekRoka;
    protected bool _veganska;

    public DateTime IstekRoka {
        get => _istekRoka;
    }
    public bool Veganska {
        get => _veganska;
    }
    public Stavka(string _naziv, DateTime _istekRoka, bool _veganska) {
        this._naziv = _naziv;
        this._istekRoka = _istekRoka; 
        this._veganska = _veganska; 
    }
    public Stavka() { _naziv = ""; }
/* -------------------------------------------------------------------------- */
    public abstract float VratiCenu();

    public virtual void Upisi(BinaryWriter bw) {
        bw.Write(_naziv);
        bw.Write(_istekRoka.Ticks);
        bw.Write(_veganska);
    }

    public virtual void Ucitaj(BinaryReader br) {
        _naziv = br.ReadString();
        _istekRoka = new DateTime(br.ReadInt64(), DateTimeKind.Local);
        _veganska = br.ReadBoolean();
    }

    public int CompareTo(object? obj) {
        if (obj is null)
            throw new ArgumentException("obj ima null vrednost");
        return VratiCenu().CompareTo(((Stavka)obj).VratiCenu());
    }
}