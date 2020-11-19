using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_auto
{
    class rulare
    {

        static void Main(string[] args)
        {
            Standard s1 = new Standard();
            s1.creareMasina();
            s1.afisareMasina();
            Camioane c1 = new Camioane();
            c1.creareMasina();                                                  // da eroare la KM daca folosesc secventa asta.
            if(Angajat.nextID==0)
                Console.WriteLine("Atelierul este inchis pentru ca nu sunt angajati");



        }
    }
}
