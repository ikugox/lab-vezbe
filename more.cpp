#include "more.h"

More::More(const char *imeFajla)
{
    
    std::ifstream fajl(imeFajla);
    if (!fajl.good())
        abort();
    
    //UCITAVANJE VELICINE
    fajl >> this->x;
    fajl >> this->y;

    //INICIJALIZACIJA 2D MATRICE
    this->polje = new OBJEKAT*[this->y];
    for (size_t i = 0; i < this->y; i++)
        this->polje[i] = new OBJEKAT[this->x];
    
    //CITANJE DATOTEKE (VODA + OSTRVA)
    char slovo;
    OBJEKAT simbol;
    for (size_t i = 0; i < this->y; i++)
        for (size_t j = 0; j < this->x; j++)
        {
            fajl >> slovo;
            if (slovo == 'O')
                simbol = OBJEKAT::OSTRVO;
            else
                simbol = OBJEKAT::VODA;
            this->polje[i][j] = simbol;
        }
    fajl.close();
}

More::~More()
{
    for (size_t i = 0; i < this->y; i++)
    {
        delete[] this->polje[i];
    }
    delete[] this->polje;
}

void More::Print()
{
    for (size_t i = 0; i < this->y; i++)
    {
        for (size_t j = 0; j < this->x; j++)
            std::cout << static_cast<char>(this->polje[i][j]);
        std::cout << std::endl;
    }
}