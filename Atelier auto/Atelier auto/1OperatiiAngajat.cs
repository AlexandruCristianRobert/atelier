using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_auto
{
    public partial class Angajat
    {
        // operatii Angajati

        //Stergere Angajat
        public void stergereAngajat(int IDstergere)
        {
            IDstergere=verifID(IDstergere);

            for (int i = IDstergere - 1; i < ID-1; i++)
            {
                nume[i] = nume[i + 1];
                prenume[i] = prenume[i + 1];
                dataAngajarii[i] = dataAngajarii[i + 1];
                dataNasterii[i] = dataNasterii[i + 1];
                salariu[i] = salariu[i + 1];
            }
            Array.Resize(ref nume, nume.Length - 1);
            Array.Resize(ref prenume, prenume.Length - 1);
            Array.Resize(ref dataAngajarii, dataAngajarii.Length - 1);
            Array.Resize(ref dataNasterii, dataNasterii.Length - 1);
            Array.Resize(ref salariu, salariu.Length - 1);
            ID--;
        }

        // calcul salariu


        public float coefsalariat;
        public double[] salariu = new double[0];
        public void Salariu(int salariuID)
        {
            salariuID = verifID(salariuID);
            DateTime timp0 = new DateTime(1, 1, 1);
            TimeSpan vechime = DateTime.Today - dataAngajarii[salariuID - 1];
            int aniVechime = (timp0 + vechime).Year - 1;
            if (aniVechime > 0)
                salariu[salariuID - 1] = aniVechime * 1000 * coefsalariat;
            else
                salariu[salariuID - 1] = 1 * 1000 * coefsalariat;
        }
        
        //  modificare angajat

        public void Modificare(string alegere,int angajatID)
        {
            angajatID = verifID(angajatID);
            switch (alegere)
            {
                case "nume":
                    nume[angajatID - 1] = SetareNume();
                    break;
                case "prenume":
                    prenume[angajatID - 1] = SetarePrenume();
                    break;
                case "data angajarii":
                    dataAngajarii[angajatID - 1] = setareDataAngajare();
                    break;
                case "Data nasterii":
                    dataNasterii[angajatID - 1] = setareDataNastere();
                    break;
                default:
                    Console.WriteLine("\nAi introdus o alegere gresita, introdu alegerea din nou:");
                    alegere = Console.ReadLine();
                    Modificare(alegere, angajatID);
                    break;
            }
        }

        // verificare ID

        public int verifID(int inputID)
        {
            if (inputID > ID || inputID < 1)
            {
                while (inputID < 1 || inputID > ID)
                {
                    Console.WriteLine("\nNu exista un angajat cu acest ID, introdu alt ID");
                    inputID = int.Parse(Console.ReadLine());
                }
            }
            return inputID;
        }

        public void redimensionare()
        {
            Array.Resize(ref nume, nume.Length + 1);
            Array.Resize(ref prenume, prenume.Length + 1);
            Array.Resize(ref dataAngajarii, dataAngajarii.Length + 1);
            Array.Resize(ref dataNasterii, dataNasterii.Length + 1);
            Array.Resize(ref salariu, salariu.Length + 1);
        }
    }
}
