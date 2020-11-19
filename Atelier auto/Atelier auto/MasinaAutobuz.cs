using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Atelier_auto
{
    public class Autobuze:Masini
    {

        int[] nrLocuri = new int[0];

        public void creareAutobuz()
        {
            Console.WriteLine("\nDoresti sa introduci o masina standard? Scrie Da sau Nu");
            string text = Console.ReadLine();
            if (text == "Da" || text == "DA" || text == "da")
            {
                while (text == "Da" || text == "DA" || text == "da")
                {
                    ID = Interlocked.Increment(ref nextID);
                    redimensionare();
                    Array.Resize(ref nrLocuri,nrLocuri.Length + 1);
                    KM[ID - 1] = setareKM();
                    Anfabric[ID - 1] = setareAnFabricatie();
                    diesel[ID - 1] = setareDiesel();
                   
                    nrLocuri[ID - 1] = setareNrLocuri();
                    Console.WriteLine("\nMasina are discount? Scrie Da sau Nu");
                    bool discount;
                    string raspuns = Console.ReadLine();
                    if (raspuns == "da" || raspuns == "DA" || raspuns == "Da")
                        discount = true;
                    else
                        discount = false;
                    calcPolita(ID, discount);
                    Console.WriteLine("\nDoresti sa introduci un alt autobuz? Scrie Da sau Nu");
                    text = Console.ReadLine();
                }
            }

        }
            public void calcPolita(int IDMasina, bool discount)
            {
                polita[IDMasina - 1] = vechime(IDMasina) * 200;
                if (diesel[IDMasina - 1])
                    polita[IDMasina - 1] += 1000;
                if (KM[IDMasina - 1] > 200000)
                    polita[IDMasina - 1] += 1000;
                else
                    if (KM[IDMasina - 1] > 100000)
                    polita[IDMasina - 1] += 500;
                if (discount)
                    polita[IDMasina - 1] = polita[IDMasina - 1] * 0.90;
            }



        public int setareNrLocuri()
        {
            Console.WriteLine("\nIntroduceti nr de locuri al autobuzului:");
            int nr = int.Parse(Console.ReadLine());
            return nr;
        }
    }
}
