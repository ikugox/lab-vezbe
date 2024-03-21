#pragma once
#include "more.h"

class Igra : private More
{
private:
    int xInput, yInput;
    bool displej, ai;
public:
    Igra(const char *imeFajlaM,
         const char *imeFajlaB,
         bool displej, bool ai)
        : More(imeFajlaM, imeFajlaB)
    {
        this->displej = displej;
        this->ai = ai;
    }
    void Kreni();
    void PrintSakriveno();
};

void Igra::PrintSakriveno()
{
    for (size_t i = 0; i < this->y; i++)
    {
        for (size_t j = 0; j < this->x; j++)
        {
            switch (this->polje[i][j])
            {
            case OBJEKAT::POGODJENO:
                std::cout << static_cast<char>(OBJEKAT::POGODJENO);
                break;
            case OBJEKAT::PROMASENO:
                std::cout << static_cast<char>(OBJEKAT::PROMASENO);
                break;
            default:
                std::cout << static_cast<char>(OBJEKAT::PRAZNO);
                break;
            }
        }
        std::cout << std::endl;
    }
}

void Igra::Kreni()
{
    while (this->IgraTraje())
    {
        this->Print();
        std::cout << this->brojBrodova << '\n';
        // if (displej)
        // else
        //     this->PrintSakriveno();
        
        if (ai)
        {
            //TODO
        }
        else
        {
            std::cin >> xInput >> yInput;
        }
        this->Pogodi(xInput, yInput);
    }
}