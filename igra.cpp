#include "igra.h"

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