#pragma once
#include "racunar.h"
#include <iostream>

class Svic
{
private:
    Racunar *racunari [24] = {nullptr};
public:
    void DodajRacunar(Racunar *obj)
    {
        for (size_t i = 0; i < 24; i++)
            if (this->racunari[i] == nullptr)
                this->racunari[i] = obj;
        std::cout << "Ne postoje vise loakcije" << std::endl;
    }
    void UkloniRacunar(std::string MAC)
    {
        for (size_t i = 0; i < 24; i++)
            if (this->racunari[i]->VratiMAC() == MAC)
            {
                delete this->racunari[i];
                return;
            }
        std::cout << "Ovaj racunar ne postoji" << std::endl;
    }
};