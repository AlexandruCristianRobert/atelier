using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Atelier_auto
{
    public partial class Masini
    {
        public Masini() { }
        public static int nextID;
        public int ID;
        public int[] KM = new int[0];
        public DateTime[] Anfabric = new DateTime[0];
        public bool[] diesel = new bool[0];
        public double[] polita = new double[0];



        public int vechime(int IDMasina)
        {
            DateTime timp0 = new DateTime(1, 1, 1);
            TimeSpan vechime = DateTime.Today - Anfabric[IDMasina - 1];
            int aniVechime = (timp0 + vechime).Year - 1;
            return aniVechime;
        }

        
        public int setareKM()
        {
            int kilometrii = 0;
            Console.WriteLine("\nintrodu nr de kilometrii ai masinii:");
            return kilometrii = int.Parse(Console.ReadLine());
        }

        public DateTime setareAnFabricatie()
        {
            Console.WriteLine("\nIntrodu data in care a fost facuta masina:");
            string textAnMasina = Console.ReadLine();
            var anFabric = DateTime.Parse(textAnMasina);
            return anFabric;
        }
        public bool setareDiesel()
        {

            Console.WriteLine("\nMasina e disel? Scrie Da");
            string raspuns = Console.ReadLine();
            if (raspuns == "da" || raspuns == "DA" || raspuns == "Da")
                return true;
            return false;
        }

        public void redimensionare()
        {
            Array.Resize(ref KM, KM.Length + 1);
            Array.Resize(ref Anfabric, Anfabric.Length + 1);
            Array.Resize(ref diesel, diesel.Length + 1);
            Array.Resize(ref polita, polita.Length + 1);
        }
    }
}
