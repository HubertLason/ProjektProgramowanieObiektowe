using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Muffin : Danie
    {
        public string wielkosc;
        public string rodzaj;


        public Muffin(string nazwa, int moc, int czas, string wielkosc,string rodzaj) : base(nazwa, moc, czas)
        {
            this.wielkosc = wielkosc;
            this.rodzaj = rodzaj;

        }
        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Wielkość:" + wielkosc);
            Console.WriteLine("Rodzaj:" + rodzaj);
        }
    }
}
