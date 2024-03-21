#pragma once
#include "objekat.h"
#include <iostream>
#include <fstream>

class More
{
private:
    OBJEKAT **polje;
    int x, y;
public:
    More(const char *imeFajla);
    virtual ~More();
    void Print();
    OBJEKAT VratiObjekat(int x, int y)
        { return this->polje[y][x]; }
    int VratiX()
        { return this->x; }
    int VratiY()
        { return this->y; }
};