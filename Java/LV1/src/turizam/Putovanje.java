package turizam;
import java.io.*;

abstract class Putovanje implements Put, Comparable<Put>
{
    protected String destinacija;
    protected int brojDana;
    protected double cenaPoDanu;

    Putovanje(String destinacija,
              int brojDana,
              double cenaPoDanu)
    {
        this.destinacija = destinacija;
        this.brojDana = brojDana;
        this.cenaPoDanu = cenaPoDanu;
    }

    @Override
    public double vratiCenu()
    {
        return this.brojDana * this.cenaPoDanu;
    }

    @Override
    public void upisiUDatoteku(String imeFajla) throws Exception
    {
        FileOutputStream fos = new FileOutputStream(imeFajla);
        BufferedOutputStream bos = new BufferedOutputStream(fos);
        DataOutputStream dos = new DataOutputStream(bos);
        dos.writeChars(destinacija);
        dos.close();
    }
    
    @Override
    public void upisiUDatoteku() throws Exception
    {
        String imeFajla = Double.toString(this.vratiCenu()) + ".txt";
        upisiUDatoteku(imeFajla);
    }

    @Override
    public int compareTo(Put obj)
    {
        return Double.compare(this.vratiCenu(), obj.vratiCenu());
        // return (int)(this.vratiCenu() - obj.vratiCenu());
    }
    
    @Override
    public void print()
    {
        System.out.println("Ime destinacije: " + this.destinacija);
        System.out.println("Broj dana: " + this.brojDana);
        System.out.println("Cena po danu: " + this.cenaPoDanu);
    }
}