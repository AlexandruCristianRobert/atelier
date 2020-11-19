using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Atelier_auto
{
    public class Standard : Masini
    {
        int[] transmisie = new int[0]; // a doua retine 0 manuala, 1 automata



        public void creareMasina()
        {
            Console.WriteLine("\nDoresti sa introduci o masina standard? Scrie Da sau Nu");
            string text = Console.ReadLine();
            if (text == "Da" || text == "DA" || text == "da")
            {
                while (text == "Da" || text == "DA" || text == "da")
                {
                    ID = Interlocked.Increment(ref nextID);
                    redimensionare();
                    Array.Resize(ref transmisie, transmisie.Length + 1);
                    KM[ID - 1] = setareKM();
                    Anfabric[ID - 1] = setareAnFabricatie();
                    diesel[ID - 1] = setareDiesel();
                    transmisie[ID - 1] = setaretransmisie();
                    Console.WriteLine("\nMasina are discount? Scrie Da sau Nu");
                    bool discount;
                    string raspuns = Console.ReadLine();
                    if (raspuns == "da" || raspuns == "DA" || raspuns == "Da")
                        discount = true;
                    else
                        discount = false;
                    calcPolita(ID, discount);
                    Console.WriteLine("\nDoresti sa introduci o alta masina standard? Scrie Da");
                    text = Console.ReadLine();
                }
            }
        }

        public void afisareMasina()
        {
            for (int i = 0; i < ID; i++)
            {
                Console.WriteLine("\nID: " + (i + 1));
                Console.WriteLine("\nKM: " + KM[i]);
                Console.WriteLine("\nData Fabricatie: " + Anfabric[i]);
                Console.WriteLine("\nE diesel? " + diesel[i]);
                Console.WriteLine("\nCostul politei: " + polita[i]);
                if (transmisie[i] == 1)
                    Console.WriteLine("\nAre transmisia automata");
                else
                    Console.WriteLine("\nAre transmisia manuala");
            }
        }
        public int setaretransmisie()
        {
            string text;
            Console.WriteLine("\nMasina are transmisie automata sau manuala? Scrie Auto sau Man");
            text = Console.ReadLine();
            while (text != "Auto" && text != "Man")
            {
                Console.WriteLine("\ni introdus o transmisie incorecta, incearca din nou (Man sau Auto).");
                text = Console.ReadLine();
            }
            if (text == "Auto")
                return 1;
            return 0;
        }

        public void calcPolita(int IDMasina, bool discount)
        {
            polita[IDMasina - 1] = vechime(IDMasina) * 100;
            if (diesel[IDMasina - 1])
                polita[IDMasina - 1] += 500;
            if (KM[IDMasina - 1] > 200000)
                polita[IDMasina - 1] += 500;

            if (discount)
                polita[IDMasina - 1] = polita[IDMasina - 1] * 0.95;
        }
        public void StergereMasinaStandard()
        {
            Console.WriteLine("Introdu id-ul masinii pe care doresti sa o stergi");
            int IDstergere = int.Parse(Console.ReadLine());

            for (int i = IDstergere - 1; i < ID - 1; i++)
            {
                KM[i] = KM[i + 1];
                Anfabric[i] = Anfabric[i + 1];
                diesel[i] = diesel[i + 1];
                polita[i] = polita[i + 1];
                transmisie[i] = transmisie[i + 1];

            }
            Array.Resize(ref KM, KM.Length - 1);
            Array.Resize(ref Anfabric, Anfabric.Length - 1);
            Array.Resize(ref diesel, diesel.Length - 1);
            Array.Resize(ref polita, polita.Length - 1);
            Array.Resize(ref transmisie, transmisie.Length - 1);
            ID--;
        }
    }
}
