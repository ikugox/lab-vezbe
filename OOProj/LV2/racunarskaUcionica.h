#pragma once
#include "svic.h"
#include "racunar.h"
#include <vector>

class RacunarskaUcionica
{
private:
    std::string oznaka;
    std::vector<Racunar*> racunari;
    Svic *svic;
public:
    RacunarskaUcionica(std::string oznaka = "")
        { this->oznaka = oznaka; }
    ~RacunarskaUcionica()
    {
        for (Racunar* r : this->racunari)
            delete r;
        racunari.clear();
    }
    std::string VratiOznaku()
        { return this->oznaka; }
    void DodajRacunar(Racunar *obj)
        { this->racunari.push_back(obj); }
    void DodajSvic(Svic *obj)
    {
        if (this->svic != nullptr)
            delete this->svic;
        this->svic = obj;
    }
    int VratiBrojRacunara()
        { return this->racunari.size(); }
    int VratiBrojIspravnihRacunara()
    {
        int brojRacunara = 0;
        for (Racunar *racunar : racunari)
            if (racunar->Sposoban())
                brojRacunara++;
        return brojRacunara;
    }
};