package turizam;

public interface Put
{
    double vratiCenu();
    void upisiUDatoteku() throws Exception;
    void upisiUDatoteku(String imeFajla) throws Exception;
    void print();
}