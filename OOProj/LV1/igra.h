#pragma once
#include "more.h"
#include "brodovi.h"

class Igra
{
private:
    More *more;
    Brodovi *brodovi;
public:
    Igra(const char *imeFajlaM,
         const char *imeFajlaB);
    ~Igra();
    void Kreni();
private:
    bool Strategija1();
    bool Strategija2();
    bool Strategija3(int smerIndeksa);
    bool Pogodi(int x, int y);
    void Print();
    void PrintKraj();
    int x, y;
};