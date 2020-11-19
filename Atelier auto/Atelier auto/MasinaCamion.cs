using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Atelier_auto
{
    public class Camioane:Masini
    {
        int[] tonaj = new int[0];


        public void creareMasina()
        {
            Console.WriteLine("\nDoresti sa introduci un camion? Scrie Da sau Nu");
            string text = Console.ReadLine();
            if (text == "Da" || text == "DA" || text == "da")
            {
                while (text == "Da" || text == "DA" || text == "da")
                {
                    ID = Interlocked.Increment(ref nextID);
                    redimensionare();
                    Array.Resize(ref tonaj, tonaj.Length + 1);
                    KM[ID - 1] = setareKM();
                    Anfabric[ID - 1] = setareAnFabricatie();
                    diesel[ID - 1] = setareDiesel();
                    tonaj[ID - 1] = setareTonaj();
                    Console.WriteLine("\nMasina are discount? Scrie Da sau Nu");
                    bool discount;
                    string raspuns = Console.ReadLine();
                    if (raspuns == "da" || raspuns == "DA" || raspuns == "Da")
                        discount = true;
                    else
                        discount = false;
                    calcPolita(ID, discount);
                    Console.WriteLine("\nDoresti sa introduci un alt camion ? Scrie Da sau Nu");
                    text = Console.ReadLine();
                }
            }
        }

        public int setareTonaj()
        {
            Console.WriteLine("\nIntroduceti tonajul camionului:");
            int tonaj = int.Parse(Console.ReadLine());
            return tonaj;
        }

        public void calcPolita(int IDMasina, bool discount)
        {
            polita[IDMasina - 1] = vechime(IDMasina) * 300;
            if (KM[IDMasina - 1] > 800000)
                polita[IDMasina - 1] += 700;
            if (discount)
                polita[IDMasina - 1] = polita[IDMasina - 1] * 0.85;
        }




    }
}
