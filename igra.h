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
};

Igra::Igra(const char *imeFajlaM,
           const char *imeFajlaB)
{
    this->more = new More(imeFajlaM);
    this->brodovi = new Brodovi(this->more, imeFajlaB);
}

Igra::~Igra()
{
    delete this->more;
    delete this->brodovi;
}
