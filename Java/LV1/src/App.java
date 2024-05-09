import turizam.Letovanje;

public class App
{
    public static void main(String[] args)
    {
        Agencija<turizam.Put> a = new Agencija<>();
        a.dodaj(new Letovanje("San Diego", 5, 120));
        a.dodaj(new Letovanje("Dubai", 30, 180));
        a.dodaj(new Letovanje("Rio de Janeiro", 10, 90));
        a.dodaj(new Letovanje("Hurghada", 12, 200));
        a.dodaj(new Letovanje("Seoul", 6, 52));
        a.dodaj(new Letovanje("Belgrade", 4, 70));
        a.print();
        try
        {
            a.uredi();
        }
        catch (Exception e) 
        {
            System.out.println("Preskupo!!!");
        }
        a.print();
        // l.upisiUDatoteku();
    }
}
