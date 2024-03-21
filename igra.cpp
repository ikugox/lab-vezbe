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

bool Igra::Pogodi(int x, int y)
{
    std::cout << x << ',' << y << ' ';
    bool pogodjeno = this->brodovi->Upucano(this->more, x, y);
    if (pogodjeno)
    {
        std::cout << "POGODJENO!!!";
    }
    else
    {
        std::cout << "PROMASENO";
    }
    std::cout << std::endl;
    this->Print();
    return pogodjeno;
}

void Igra::Kreni()
{
    while (this->brodovi->PostojeBrodovi())
    {
        if (!this->Strategija1())
            break;
        int x = this->Strategija2();
        if (!this->brodovi->PostojeBrodovi())
            break;
        if (!this->Strategija3(x))
            break;
    }
    this->PrintKraj();
}

bool Igra::Strategija1()
{
    while (true)
    {
        this->x = rand() % this->more->VratiX();
        this->y = rand() % this->more->VratiY();
        if (this->Pogodi(this->x, this->y))
            break;
    }
    if (!this->brodovi->PostojeBrodovi())
        return false;
    
    return true;
}

static Kordinate smerovi[4] = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};

bool Igra::Strategija2()
{
    for (size_t i = 0; i < 4; i++)
    {
        int xSmer = smerovi[i].x;
        int ySmer = smerovi[i].y;
        x += xSmer;
        y += ySmer;
        if (!this->Pogodi(this->x, this->y))
        {
            x -= xSmer;
            y -= ySmer;
        }
        else
        {
            return (i % 2);
        }
    }
    return false;
}

bool Igra::Strategija3(int smerIndeks)
{
    int xStart = this->x,
        yStart = this->y;
    for (size_t i = 0; i < 2; i++)
        while (true)
        {
            int xSmer = smerovi[smerIndeks].x;
            int ySmer = smerovi[smerIndeks].y;
            x += xSmer;
            y += ySmer;
            if (!this->Pogodi(this->x, this->y))
            {
                this->x = xStart;
                this->y = yStart;
                smerIndeks += 2;
                break;
            }
        }
    if (!this->brodovi->PostojeBrodovi())
        return false;
    return true;
}

void Igra::Print()
{
    for (size_t i = 0; i < this->more->VratiY(); i++)
    {
        for (size_t j = 0; j < this->more->VratiX(); j++)
        {
            if (this->brodovi->PostojeKordinate(j, i) &&
               !this->brodovi->PostojeZiveKordinate(j, i))
                std::cout << static_cast<char>(OBJEKAT::POGODJENO);
            else
                std::cout << static_cast<char>(this->more->VratiObjekat(j, i));
        }
        std::cout << std::endl;
    }
    std::cout << std::endl;
}

void Igra::PrintKraj()
{
    for (size_t i = 0; i < this->more->VratiY(); i++)
    {
        for (size_t j = 0; j < this->more->VratiX(); j++)
        {
            if (this->brodovi->PostojeKordinate(j, i))
                std::cout << static_cast<char>(OBJEKAT::BROD);
            else
                std::cout << static_cast<char>(this->more->VratiObjekat(j, i));
        }
        std::cout << std::endl;
    }
}