#include "brodovi.h"

//TODO: REMOVE!
void Brodovi::Print()
{
    for (size_t i = 0; i < this->brojBrodova; i++)
        std::cout << this->pozicije[i].x << ','
                  << this->pozicije[i].y << '\n';

    // for (size_t i = 0; i < this->brojSvihBrodova; i++)
    //     std::cout << this->svePozicije[i].x << ','
    //               << this->svePozicije[i].y << '\n';
    
    std::cout << '\n';
}

Brodovi::Brodovi()
{
    this->brojBrodova = 0;
    this->pozicije = nullptr;
    this->brojSvihBrodova = 0;
    this->svePozicije = nullptr;
}

Brodovi::Brodovi(More *more, const char *imeFajla)
    : Brodovi()
{
    this->Ucitaj(more, imeFajla);
}

Brodovi::~Brodovi()
{
    delete[] this->pozicije;
}

bool Brodovi::ProveraValidnosti(More *more, OBJEKAT **kopijaMora, int x, int y)
{
    //LOKACIJA
    if (kopijaMora[y][x] == OBJEKAT::BROD ||
        kopijaMora[y][x] == OBJEKAT::OSTRVO)
        return false;
    
    //IVICE
    if (x <= 0 || x >= more->VratiX())
        return false;
    if (y <= 0 || y >= more->VratiY())
        return false;
    
    //SUSEDNA POLJA
    if (kopijaMora[y + 1][x] == OBJEKAT::OSTRVO ||
        kopijaMora[y + 1][x] == OBJEKAT::BROD)
        return false;
    if (kopijaMora[y - 1][x] == OBJEKAT::OSTRVO ||
        kopijaMora[y - 1][x] == OBJEKAT::BROD)
        return false;
    if (kopijaMora[y][x + 1] == OBJEKAT::OSTRVO ||
        kopijaMora[y][x + 1] == OBJEKAT::BROD)
        return false;
    if (kopijaMora[y][x - 1] == OBJEKAT::OSTRVO ||
        kopijaMora[y][x - 1] == OBJEKAT::BROD)
        return false;
    
    return true;
}

void Brodovi::Ucitaj(More *more, const char *imeFajla)
{
    std::ifstream fajl(imeFajla);
    if (!fajl.good())
        return;
    
    //INICIJALIZACIJA
    OBJEKAT **kopijaMora = new OBJEKAT*[more->VratiY()];
    for (size_t i = 0; i < more->VratiY(); i++)
    {
        kopijaMora[i] = new OBJEKAT[more->VratiY()];
        for (size_t j = 0; j < more->VratiY(); j++)
            kopijaMora[i][j] = more->VratiObjekat(j, i);
    }
    int brojBrodova;
    fajl >> brojBrodova;
    
    int pozX, pozY;
    int duzina;
    bool uspravno;
    for (size_t i = 0; i < brojBrodova; i++)
    {
        //ZA SVAKI BROD...
        fajl >> pozX >> pozY >> duzina >> uspravno;
        // std::cout << ' '<< pozX
        //           << ' '<< pozY
        //           << ' '<< duzina
        //           << ' '<< uspravno;
        // std::cout << '\n' << this->brojBrodova << std::endl;

        //PROVERA VALIDNOSTI
        bool validno;
        for (size_t j = 0; j < duzina; j++)
        {
            validno = this->ProveraValidnosti(more, kopijaMora,
                                              pozX + j*!uspravno,
                                              pozY + j*uspravno);
            if (duzina < 2)
                validno = false;
            if (!validno)
                break;
        }
        if (!validno)
            continue;
        
        //UPISIVANJE
        for (size_t j = 0; j < duzina; j++)
        {
            kopijaMora[pozY + j*uspravno][pozX + j*!uspravno] = OBJEKAT::BROD;
            this->Dodaj(Kordinate(pozX + j*!uspravno, pozY + j*uspravno));
        }
    }
    this->brojSvihBrodova = this->brojBrodova;
    this->svePozicije = new Kordinate[this->brojSvihBrodova];
    for (size_t i = 0; i < this->brojSvihBrodova; i++)
        this->svePozicije[i] = this->pozicije[i];

    fajl.close();
}

bool Brodovi::Upucano(More *more, int x, int y)
{
    //PROVERA VALIDNOSTI
    if (x < 0 || x >= more->VratiX())
        return false; //TODO! promeni u throw
    if (y < 0 || y >= more->VratiY())
        return false;
    
    //
    bool postoji = false;
    for (size_t i = 0; i < this->brojBrodova; i++)
    {
        if (this->pozicije[i] == Kordinate(x, y))
            postoji = true;
        if (postoji)
            this->pozicije[i] = this->pozicije[i + 1];
    }
    if (postoji)
        this->brojBrodova--;
    
    return postoji;
}

void Brodovi::Dodaj(Kordinate obj)
{
    Kordinate *novePozicije = new Kordinate[this->brojBrodova + 1];
    for (size_t i = 0; i < this->brojBrodova; i++)
        novePozicije[i] = this->pozicije[i];
    novePozicije[this->brojBrodova] = obj;
    
    delete this->pozicije;
    this->pozicije = novePozicije;
    
    this->brojBrodova++;
}

bool Brodovi::PostojeBrodovi()
{
    return this->brojBrodova != 0;
}

bool Brodovi::PostojeKordinate(int x, int y)
{
    for (size_t i = 0; i < this->brojSvihBrodova; i++)
        if (this->svePozicije[i] == Kordinate(x, y))
            return true;
    return false;
}

bool Brodovi::PostojeZiveKordinate(int x, int y)
{
    for (size_t i = 0; i < this->brojBrodova; i++)
        if (this->pozicije[i] == Kordinate(x, y))
            return true;
    return false;
}