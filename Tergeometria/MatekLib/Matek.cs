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
            int felszin = 2 * ((szam1 * szam2) + (szam2 * szam3) + (szam3 * szam1));
            int térfogat = szam1 * szam2 * szam3;

            if (felszin == térfogat)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Szam1 { get; init; }
        public int Szam2 { get; init; }
        public int Szam3 { get; init; }
        public bool HelyesMegoldás { get; init; }


        public override string ToString()
        {
            return $"a={Szam1}; b={Szam2}; c={Szam3}";
        }
    }
}
