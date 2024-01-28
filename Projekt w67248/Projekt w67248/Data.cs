using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Data
    {
        public int temperatura;
        public int czas;
        public string nazwa;
        public string status;

        public Data(int temperatura, int czas, string nazwa, string status)
        {
            this.temperatura = temperatura;
            this.czas = czas;
            this.nazwa = nazwa;
            this.status = status;
        }
        public void Wypisz()
        {
            Console.WriteLine("Nazwa dania:" + nazwa);
            Console.WriteLine("Temperatura:"+temperatura);
            Console.WriteLine("Czas:" + czas);
            Console.WriteLine(status);
        }
    }
}
