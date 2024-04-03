package turizam;

public class Zimovanje extends Putovanje
{
    private double cenaSkiPasaPoDanu;

    public Zimovanje(String destinacija,
                     int brojDana,
                     double cenaPoDanu,
                     double cenaSkiPasaPoDanu)
    {
        super(destinacija, brojDana, cenaPoDanu);
        this.cenaSkiPasaPoDanu = cenaSkiPasaPoDanu;
    }

    @Override
    public double vratiCenu()
    {
        return super.vratiCenu() + this.cenaSkiPasaPoDanu * (this.brojDana - 2);
    }

    @Override
    public void print()
    {
        super.print();
        System.out.println("Cena ski pasa po danu: " + this.cenaSkiPasaPoDanu);
    }
}