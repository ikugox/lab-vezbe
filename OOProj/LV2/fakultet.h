#pragma once
#include "racunarskaUcionica.h"
#include <string>
#include <vector>

class Fakultet
{
private:
    std::string ime;    
    std::vector<RacunarskaUcionica*> ucionice;
    static Fakultet* instanca;
    Fakultet(const char *ime)
        { this->ime = ime; };
public:
    ~Fakultet()
    {
        while(!this->ucionice.empty())
        {
            auto x = ucionice.back();
            delete x;
            ucionice.pop_back();
        }
    }
    static Fakultet* Instanciraj(const char *ime)
    {
        if (!instanca)
            instanca = new Fakultet(ime);
        return instanca;
    }
    void DodajUcionicu(RacunarskaUcionica *obj)
        { ucionice.push_back(obj); }
    RacunarskaUcionica* VratiUcionicu(std::string imeUcionice)
    {
        for (RacunarskaUcionica *ucionica : ucionice)
        {
            if (ucionica->VratiOznaku() == imeUcionice)
                return ucionica;
        }
        return new RacunarskaUcionica();
    }
    void VratiBrojRacunara()
    {
        std::cout << "Broj racunara:\n";
        for (RacunarskaUcionica *ucionica : ucionice)
            std::cout << ucionica->VratiOznaku()
                      << ": "
                      << ucionica->VratiBrojRacunara()
                      << std::endl;
    }
    void VratiBrojIspravnihRacunara()
    {
        std::cout << "Broj ispravnih racunara:\n";
        for (RacunarskaUcionica *ucionica : ucionice)
            std::cout << ucionica->VratiOznaku()
                      << ": "
                      << ucionica->VratiBrojIspravnihRacunara()
                      << std::endl;
    }
};