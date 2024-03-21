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
    void Strategija1();
    void Strategija2();
    void Strategija3(int smerIndeksa);
    bool Pogodi(int x, int y);
    int x, y;
};