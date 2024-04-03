import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class Agencija <T extends turizam.Put>
{
    private ArrayList<T> lista = new ArrayList<>();

    public void print()
    {
        for (T element : lista)
        {
            element.print();
            System.out.println();    
        }
        System.out.println("-----------------");    
    }

    public void dodaj(T obj)
    {
        lista.add(obj);
    }

    public void uredi() throws Exception
    {
        // Collections.<turizam.Put>sort(lista);
        lista.sort(null);
        // Collections.sort(lista,
        //     new Comparator<T>()
        //     {
        //         @Override
        //         public int compare(T obj1, T obj2)
        //         {
        //             return Double.compare(obj1.vratiCenu(), obj2.vratiCenu());
        //         }
        //     });

        for (int i = 0; i < this.lista.size() - 1; i++)
            lista.get(i).upisiUDatoteku();

        if (this.lista.getLast().vratiCenu() >= 2000)
            throw new inflacija.Preskupo("damn");
        else
            this.lista.getLast().upisiUDatoteku("ekskluziva.bin");
    }
}