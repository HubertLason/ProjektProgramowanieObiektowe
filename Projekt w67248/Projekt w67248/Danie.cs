using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public abstract class Danie
    {
        public string Nazwa;
        public int Moc;
        public int Czas;

        public Danie(string nazwa, int moc, int czas)
        {
            this.Nazwa = nazwa;
            this.Moc = moc;
            this.Czas = czas;
        }

        public virtual void Wypisz()
        {
            Console.WriteLine("Nazwa:"+Nazwa);
            Console.WriteLine("Zalecana moc:" + Moc);
            Console.WriteLine("Zalecany czas:" + Czas);
        }

    }
}
