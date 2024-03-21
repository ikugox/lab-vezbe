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
    // this->brodovi->Print();
    bool pogodjeno = this->brodovi->Upucano(this->more, x, y);
    std::cout << x << ',' << y << ' ';
    if (pogodjeno)
    {
        std::cout << "POGODJENO!!!";
    }
    else
    {
        std::cout << "PROMASENO";
    }
    std::cout << std::endl;
    return pogodjeno;
}

void Igra::Kreni()
{
    while (!this->brodovi->PostojeBrodovi())
    {
        this->Strategija1();
    }
}

void Igra::Strategija1()
{
    while (true)
    {
        this->x = rand() % this->more->VratiX();
        this->y = rand() % this->more->VratiY();
        if (this->Pogodi(this->x, this->y))
            break;
    }
    this->Strategija2();
    return;
}

static Kordinate smerovi[4] = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};

void Igra::Strategija2()
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
            this->Strategija3(i % 2);
            return;
        }
    }
}

void Igra::Strategija3(int smerIndeks)
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
    return;
}