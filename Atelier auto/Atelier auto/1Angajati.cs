/*  3 tipuri de angajati
    3 subclase      director
                    mecanic
                    asistent

Campuri pentru fiecare: ID
                        Nume
                        Prenume
                        Data Nasterii
                        Data Angajarii
                        Coeficient Salariat

Functii de implementat  Afisare angajati
                        Adaugare angajat
                        Stergere angajat
                        Editare angajat
                        calculare salariu angajat



Observatii  :           ID-ul se incrementeaza

                        coef salarial :     Director 2
                                            Mecanic 1.5
                                            Asistent 1

                        Nume prenume nu sunt nule si maxim 30 char

                        Varsta minima 18 la data angajarii!

                        Data angajarii doar in trecut

                        Stergerea, editarea si calcularea salariului se fac pe baza id-ului acestuia

                        calcul salarial = ani vechime*coeficient*1000 lei
             */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Atelier_auto
{
    public partial class Angajat
    {
        public static int nextID;
        public int ID = 0;
        
        public void afisare()
        {
            for(int i=0;i<ID;i++)
            {
            Console.WriteLine("\nID: " + (i+1));
            Console.WriteLine("\nNume: " + nume[i]);
            Console.WriteLine("\nPrenume: " + prenume[i]);
            Console.WriteLine("\nData angajarii: " + dataAngajarii[i]);
            Console.WriteLine("\nData nasterii: " + dataNasterii[i]);
            Console.WriteLine("\nSalariul: " + salariu[i] + " Ron");
            }
        }

    }

    public class Director : Angajat
    {

        public Director()
        {
            Console.WriteLine("\nDoresti sa introduci un angajat? Scrie Da");
            string alegere;
            alegere = Console.ReadLine();
            if (alegere == "Da" || alegere == "DA" || alegere == "da")
            {
                while (alegere == "Da" || alegere == "DA" || alegere == "da")
                {
                    volumM
                    redimensionare();
                    ID = Interlocked.Increment(ref nextID);
                    nume[ID - 1] = SetareNume();
                    prenume[ID - 1] = SetarePrenume();
                    dataAngajarii[ID - 1] = setareDataAngajare();
                    dataNasterii[ID - 1] = setareDataNastere();
                    coefsalariat = 2F;
                    Console.WriteLine("\nDaca doresti sa introduci un alt angajat? Scrie Da");
                    alegere = Console.ReadLine();
                }
            }

        }
    }

    public class Mecanic : Angajat
    {
        public Mecanic()
        {
            Console.WriteLine("\nDoresti sa introduci un angajat? Scrie Da");
            string alegere;
            alegere = Console.ReadLine();
            if (alegere == "Da" || alegere == "DA" || alegere == "da")
            {
                while (alegere == "Da" || alegere == "DA" || alegere == "da")
                {
                    redimensionare();
                    ID = Interlocked.Increment(ref nextID);
                    nume[ID - 1] = SetareNume();
                    prenume[ID - 1] = SetarePrenume();
                    dataAngajarii[ID - 1] = setareDataAngajare();
                    dataNasterii[ID - 1] = setareDataNastere();
                    coefsalariat = 1.5F;
                    Console.WriteLine("\nDaca doresti sa introduci un alt angajat? Scrie Da");
                    alegere = Console.ReadLine();
                }
            }
        }

    }

    public class Asistent : Angajat
    {
        public Asistent()
        {
            Console.WriteLine("\nDoresti sa introduci un angajat? Scrie Da");
            string alegere;
            alegere = Console.ReadLine();
            if (alegere == "Da" || alegere == "DA" || alegere == "da")
            {
                while (alegere == "Da" || alegere == "DA" || alegere == "da")
                {
                    redimensionare();
                    ID = Interlocked.Increment(ref nextID);
                    nume[ID - 1] = SetareNume();
                    prenume[ID - 1] = SetarePrenume();
                    dataAngajarii[ID - 1] = setareDataAngajare();
                    dataNasterii[ID - 1] = setareDataNastere();
                    coefsalariat = 1F;
                    Console.WriteLine("\nDaca doresti sa introduci un alt angajat? Scrie Da");
                    alegere = Console.ReadLine();
                }
            }

        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Director d1 = new Director();
    //        d1.stergereAngajat(5);
    //        d1.Salariu(51);
    //        d1.afisare();

    //    }
    //}
}
