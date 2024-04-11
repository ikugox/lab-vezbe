// #include "all_headers.h"
#include "sviHeaderi.h"

Fakultet* Fakultet::instanca = nullptr;
int main()
{
    Fakultet* f = Fakultet::Instanciraj("Elfak");
    f->DodajUcionicu(new RacunarskaUcionica("K4"));
    f->DodajUcionicu(new RacunarskaUcionica("523"));
    f->DodajUcionicu(new RacunarskaUcionica("K5"));
    f->VratiUcionicu("K5")->DodajRacunar(new Racunar());
    f->VratiUcionicu("K4")->DodajRacunar(new Racunar());
    f->VratiUcionicu("K5")->DodajRacunar(new Racunar());
    f->VratiUcionicu("523")->DodajRacunar(new Racunar());
    f->VratiUcionicu("K4")->DodajRacunar(new Racunar());
    f->VratiUcionicu("K5")->DodajRacunar(new Racunar(false));
    // f->VratiUcionicu("1000")->DodajRacunar(new Racunar());
    f->VratiUcionicu("K5")->DodajRacunar(new Racunar());

    f->VratiBrojRacunara();
    f->VratiBrojIspravnihRacunara();
    delete f;
    
    return 1;
}