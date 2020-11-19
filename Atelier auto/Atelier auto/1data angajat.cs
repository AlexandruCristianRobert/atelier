using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_auto
{
    public partial class Angajat
    {
        public DateTime[] dataNasterii = new DateTime[0];
        public DateTime[] dataAngajarii = new DateTime[0];

        public DateTime setareDataAngajare()
        {
            Console.WriteLine("\nIntrodu data la care a fost angajat " + ID + " (formatul este DD MM YYYY):");

            string textDAngajare = Console.ReadLine();
            var dataDAngajare = DateTime.Parse(textDAngajare);
            while(!verifDataAngajare(dataDAngajare))
            {
                Console.WriteLine("\nData angajarii nu poate fi in viitor, te rugam sa introduci alta data:");
                textDAngajare = Console.ReadLine();
                dataDAngajare = DateTime.Parse(textDAngajare);
            }
            return dataDAngajare;
        }

        public DateTime setareDataNastere()
        {
            Console.WriteLine("\nIntrodu data nasterii(formatul este DD MM YYYY):");

            string textDNastere = Console.ReadLine();
            var dataDNastere = DateTime.Parse(textDNastere);
            while(!verifVarsta(dataDNastere,dataAngajarii[ID-1]))
            {
                Console.WriteLine(nume[ID-1]+" "+ prenume[ID-1]+ " \nnu are inca 18 ani, introdu alta data de nastere");
                textDNastere = Console.ReadLine();
                dataDNastere = DateTime.Parse(textDNastere);
            }
            return dataDNastere;
        }

        public bool verifVarsta(DateTime dataNastere,DateTime dataAngajare)
        {
            if ((dataAngajare - dataNastere).TotalDays < 6570)
            {
                return false;
            }
            return true;
        }

        public bool verifDataAngajare(DateTime dataAngajare)
        {
            
            if (DateTime.Compare(dataAngajare, DateTime.Today) > 0)
                return false;
            return true;
        }
    }
}
