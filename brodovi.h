#pragma once
#include "objekat.h"
#include "more.h"

struct Kordinate
{
    int x, y;
};

class Brodovi
{
private:
    Kordinate *pozicije;
    int brojBrodova;    
public:
    Brodovi();
    ~Brodovi();
    void Ucitaj(More more, const char *imeFajlaB);
private:
    bool ProveraValidnosti(More *more, int x, int y);
};

Brodovi::Brodovi()
{
    this->brojBrodova = 0;
    this->pozicije = nullptr;
}

Brodovi::~Brodovi()
{
    delete[] this->pozicije;
}



#include "more.h"

bool Brodovi::ProveraValidnosti(More *more, int x, int y)
{
    //LOKACIJA
    if (more->VratiObjekat(x, y) == OBJEKAT::BROD ||
        more->VratiObjekat(x, y) == OBJEKAT::OSTRVO)
        return false;
    
    //IVICE
    if (x <= 0 || x >= more->VratiX())
        return false;
    if (y <= 0 || y >= more->VratiY())
        return false;
    
    //SUSEDNA POLJA
    if (more->VratiObjekat(x, y + 1) == OBJEKAT::OSTRVO ||
        more->VratiObjekat(x, y + 1) == OBJEKAT::BROD)
        return false;
    if (more->VratiObjekat(x, y - 1) == OBJEKAT::OSTRVO ||
        more->VratiObjekat(x, y - 1) == OBJEKAT::BROD)
        return false;
    if (more->VratiObjekat(x + 1, y) == OBJEKAT::OSTRVO ||
        more->VratiObjekat(x + 1, y) == OBJEKAT::BROD)
        return false;
    if (more->VratiObjekat(x - 1, y) == OBJEKAT::OSTRVO ||
        more->VratiObjekat(x - 1, y) == OBJEKAT::BROD)
        return false;
    
    return true;
}

void Brodovi::Ucitaj(More more, const char *imeFajla)
{
    std::ifstream fajl(imeFajla);
    if (!fajl.good())
        return;
    
    //INICIJALIZACIJA
    int brojBrodova;
    fajl >> brojBrodova;
    int pozX, pozY;
    int duzina;
    bool uspravno;

    for (size_t i = 0; i < brojBrodova; i++)
    {
        //ZA SVAKI BROD...
        fajl >> pozX >> pozY >> duzina >> uspravno;
        
        //PROVERA VALIDNOSTI
        bool validno;
        for (size_t j = 0; j < duzina; j++)
        {
            validno = this->ProveraValidnosti(&more,
                                              pozX + j*!uspravno,
                                              pozY + j*uspravno);
            if (duzina < 2)
                validno = false;
            if (!validno)
                break;
        }
        if (!validno)
            continue;
        
        for (size_t j = 0; j < duzina; j++)
            more.VratiObjekat(pozX + j*!uspravno, pozY + j*uspravno) = OBJEKAT::BROD;
        
        this->brojBrodova += duzina;
    }

    fajl.close();
}

void More::Pogodi(int x, int y)
{
    //PROVERA VALIDNOSTI
    if (x < 0 || x >= this->x)
        return; //TODO! promeni u throw
    if (y < 0 || y >= this->y)
        return;
    
    if (this->polje[y][x] == OBJEKAT::BROD)
    {
        this->polje[y][x] = OBJEKAT::POGODJENO;
        this->brojBrodova--;
    }
    else
        this->polje[y][x] = OBJEKAT::PROMASENO;
}