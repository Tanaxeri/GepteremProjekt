using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class Gepterem
    {

        readonly string nev;
        readonly int sorDb;
        readonly int helyDb;
        readonly int[,] ertekeles;

        public string Nev => nev;
        public int SorDb => sorDb;
        public int HelyDb => helyDb;
        public int[,] Ertekeles => ertekeles;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles)
        {

            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
  
        }

        public double Atlag()
        {

            double sum = 0;
            int db = 0;
            for (int i = 0; i < sorDb; i++)
            {

                for (int j = 0; j < helyDb; j++)
                {

                    if (ertekeles[i, j] > 0)
                    {

                        sum += ertekeles[i, j];
                        db++;

                    }

                }

            }

            return sum / db;

        }

    }
}
