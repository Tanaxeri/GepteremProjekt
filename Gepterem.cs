using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class Gepterem
    {

        int[,] ertekeles;
        int helyDb;
        int sorDb;
        string nev;

        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }
        public string Nev { get => nev; set => nev = value; }

        public Gepterem(int[,] ertekeles, int helyDb, int sorDb, string nev)
        {
            this.ertekeles = ertekeles;
            this.helyDb = helyDb;
            this.sorDb = sorDb;
            this.nev = nev;
        }


    }
}
