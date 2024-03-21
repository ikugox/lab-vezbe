#pragma once
#include "objekat.h"
#include "more.h"

struct Kordinate
{
    int x, y;
    bool operator==(Kordinate obj)
    {
        if (this->x != obj.x)
            return false;
        if (this->y != obj.y)
            return false;
        return true;
    }
    Kordinate (size_t x = 0, size_t y = 0)
    {
        this->x = x;
        this->y = y;
    }

};

class Brodovi
{
private:
    Kordinate *pozicije;
    int brojBrodova;    
public:
    Brodovi();
    Brodovi(More *more, const char *imeFajla);
    ~Brodovi();
    void Ucitaj(More *more, const char *imeFajlaB);
    bool DaLiPostoji(More *more, int x, int y);
private:
    bool ProveraValidnosti(More *more, OBJEKAT **kopijaMora, int x, int y);
    void Dodaj(Kordinate obj);
};