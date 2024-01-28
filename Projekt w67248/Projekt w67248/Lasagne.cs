using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Lasagne : Danie
    {
        public string Rodzaj;

        public Lasagne(string nazwa, int moc, int czas, string rodzaj) : base(nazwa, moc, czas)
        {
            this.Rodzaj = rodzaj;
        }

        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Rodzaj:"+Rodzaj);
        }
    }
}
