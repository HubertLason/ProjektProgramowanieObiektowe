using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Popcorn : Danie
    {
        public int waga;

        public Popcorn(string nazwa, int moc, int czas, int waga) : base(nazwa, moc, czas)
        {
            this.waga = waga;
        }
        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Waga:" + waga);
        }
    }
}
