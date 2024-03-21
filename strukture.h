#pragma once
#include <iostream>
#include <fstream>

enum class OBJEKAT : char
{
    POGODJENO = '0',
    PROMASENO = '/',
    VODA = '~',
    OSTRVO = 'c',
    BROD = 'B',
    PRAZNO = '_'
};

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