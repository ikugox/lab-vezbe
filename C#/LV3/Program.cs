class Program {
    public static void Main(string[] args) {
        Jelo j1 = new("Tofu", DateTime.Today.AddDays(-2), true,
                       99.9f, KvalitetJela.Odlican);

        Restoran r = new("ime");
        r.DodajStavku(j1);
        // r.DodajStavku(j);
        // r.DodajStavku(j);
    } 
}