#pragma once
#include <string>

class Racunar
{
private:
    bool ispravan;
    std::string MAC;
    Tastatura *tastatura;
    Monitor *monitor;
    CPU *cpu;
    RAM *ram;
    Memorija *memorija;
public:
    Racunar(bool ispravan = true,
            std::string MAC = "",
            Tastatura *tastatura = nullptr,
            Monitor *monitor = nullptr,
            CPU *cpu = nullptr,
            RAM *ram = nullptr,
            Memorija *memorija = nullptr)
    {
        this->ispravan = ispravan;
        this->MAC = MAC;
        this->tastatura = tastatura;
        this->monitor = monitor;
        this->cpu = cpu;
        this->ram = ram;
        this->memorija = memorija;
    }
    ~Racunar()
    {
        delete this->tastatura;
        delete this->monitor;
        delete this->cpu;
        delete this->ram;
        delete this->memorija;
    }
    std::string VratiMAC()
        { return this->MAC; }
    void PromenaIspravnosti()
        { this->ispravan = !ispravan; }
    bool Sposoban()
        { return this->ispravan; }
};