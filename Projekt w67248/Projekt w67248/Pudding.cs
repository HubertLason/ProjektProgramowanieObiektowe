using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Pudding : Danie
    {
        public string smak;
        public Pudding(string nazwa, int moc, int czas, string smak) : base(nazwa, moc, czas)
        {
            this.smak = smak;
        }
        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Smak:" + smak);
        }
    }
}
