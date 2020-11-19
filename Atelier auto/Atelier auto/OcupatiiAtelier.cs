using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_auto
{
    public partial class Angajat
    {
        public int[] volStandard = new int[0];
        public int[] volAutobuz = new int[0];
        public int[] volCamion = new int[0];
        public bool verifStandard(int[] a)
        {
            if (a[0] < 3)
                return true;
            return false;
        }

        public bool verifAutobuz(int[] a)
        {
            if (a[0] < 1)
                return true;
            return false;
        }

        public bool verifCamion(int[] a)
        {
            if (a[0] < 1)
                return true;
            return false;
        }
    }
}
