using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Pizza : Danie
    {
        public int srednica;

        public Pizza(string nazwa, int moc, int czas, int srednica) : base(nazwa, moc, czas)
        {
            this.srednica = srednica;
        }

        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Średnica:" + srednica);
        }
    }
}
