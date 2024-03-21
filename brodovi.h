#pragma once
#include "more.h"

class Brodovi
{
private:
    Kordinate *pozicije;
    int brojBrodova;    
public:
    Brodovi();
    Brodovi(More *more, const char *imeFajla);
    ~Brodovi();
    bool DaLiPostoji(More *more, int x, int y);
private:
    void Ucitaj(More *more, const char *imeFajlaB);
    bool ProveraValidnosti(More *more, OBJEKAT **kopijaMora, int x, int y);
    void Dodaj(Kordinate obj);
};