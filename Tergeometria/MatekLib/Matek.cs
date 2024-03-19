using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatekLib
{
    public class Matek
    {
        public Matek(int szam1, int szam2, int szam3)
        {
            Szam1 = szam1;
            Szam2 = szam2;
            Szam3 = szam3;

            HelyesMegoldás = Megoldó(szam1, szam2, szam3);
        }

        private bool Megoldó(int szam1, int szam2, int szam3)
        {
            throw new NotImplementedException();
        }

        public int Szam1 { get; init; }
        public int Szam2 { get; init; }
        public int Szam3 { get; init; }
        public bool HelyesMegoldás { get; init; }


    }
}
