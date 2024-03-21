#pragma once
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