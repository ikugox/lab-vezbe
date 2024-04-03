package turizam;

public class Letovanje extends Putovanje
{
    public Letovanje(String destinacija,
              int brojDana,
              double cenaPoDanu)
    {
        super(destinacija, brojDana, cenaPoDanu);
    }

    @Override
    public double vratiCenu()
    {
        return super.vratiCenu() * (Math.random() + 1);
    }
}