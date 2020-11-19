using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_auto
{
    public partial class Angajat
    {
        public string[] nume =  new string[0];
        public string[] prenume = new string[0];
        public bool verificareNume(string nume)
        {
            if (nume != null && nume.Length <= 30)
            {
                return true;
            }
            return false;

        }
        public string SetareNume()
        {
            Console.WriteLine("\nID Angajat:" + ID);
            Console.WriteLine("\nIntrodu numele angajatului:");
            string numeValid = Console.ReadLine();
            while (!verificareNume(numeValid))
            {
                Console.WriteLine("\nAi introdus un nume incompatibil, incearca iar");
                numeValid = Console.ReadLine();
            }

            return numeValid;
        }
        public string SetarePrenume()
        {
            Console.WriteLine("\nIntrodu prenumele angajatului:");
            string prenumeValid = Console.ReadLine();
            while (!verificareNume(prenumeValid))
            {
                Console.WriteLine("\nAi introdus un prenume incompatibil, incearca iar");
                prenumeValid = Console.ReadLine();
            }

            return prenumeValid;
        }
    }
}
