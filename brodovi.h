#pragma once
#include "more.h"

class Brodovi
{
private:
    Kordinate *pozicije;
    int brojBrodova;    
    Kordinate *svePozicije;
    int brojSvihBrodova;
public:
    void Print();
    Brodovi();
    Brodovi(More *more, const char *imeFajla);
    ~Brodovi();
    bool Upucano(More *more, int x, int y);
    bool PostojeBrodovi();
    bool PostojeKordinate(int x, int y);
    bool PostojeZiveKordinate(int x, int y);
private:
    void Ucitaj(More *more, const char *imeFajlaB);
    bool ProveraValidnosti(More *more, OBJEKAT **kopijaMora, int x, int y);
    void Dodaj(Kordinate obj);
};