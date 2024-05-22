class Program {
    public static void Main(string[] args) {
        Jelo j1 = new("Tofu", DateTime.Today.AddDays(3), true,
                       99.99f, KvalitetJela.Odlican);
        Jelo j2 = new("Tofu", DateTime.Today.AddDays(10), true,
                       99.99f, KvalitetJela.Odlican);
        Jelo j3 = new("Piletina", DateTime.Today.AddDays(-2), true,
                       129.99f, KvalitetJela.Dobar);
        Jelo j4 = new("Pljeskavica", DateTime.Today.AddDays(6), true,
                       219.99f, KvalitetJela.Prihvatljiv);
        Pice p1 = new("Vino", DateTime.Today.AddDays(85), true,
                       1.2f, 379.2f, true);
        Pice p2 = new("Vino", DateTime.Today.AddDays(64), true,
                       1.2f, 379.2f, false);
        Pice p3 = new("Pivo", DateTime.Today.AddDays(3), true,
                       0.33f, 363.63f, true);
        Pice p4 = new("Buci buci breskosaurus", DateTime.Today.AddDays(12), true,
                       0.2f, 9.6f, true);
        try {
            Restoran r1 = new("Kul Ime Restorana TM");
            string imeFajla = "podaci.bin";
            r1.DodajStavku(j1);
            r1.DodajStavku(j2);
            r1.DodajStavku(j3);
            r1.DodajStavku(j4);
            r1.DodajStavku(p1);
            r1.DodajStavku(p2);
            r1.DodajStavku(p3);
            r1.DodajStavku(p4);
            r1.Upisi(imeFajla);
            Restoran r2 = new("Jos Bolje Ime Restorana TM");
            r2.Ucitaj(imeFajla);
            r2.IzbaciPokvareno();
            r2.Sortitaj();
            r2.VeganProvera();

            r1.Print();
            Console.WriteLine("------------------------");
            r2.Print();
        }
        catch (Exception e) {
            Console.WriteLine("Nayy!");
            Console.WriteLine(e.Source);
        }

    } 
}