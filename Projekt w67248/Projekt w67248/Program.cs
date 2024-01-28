using Newtonsoft.Json;
using System.Numerics;

namespace Projekt_w67248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lasagne lasagneBolognese = new Lasagne("Lasagne bolognese", 850,9, "bolognese");
            Lasagne lasagneNapoli = new Lasagne("Lasagne napoli", 850, 10, "napoli");
            Pizza MalaMargherita = new Pizza("Mała margherita", 800, 4, 24);
            Pizza DuzaMargherita = new Pizza("Duza margherita", 800, 6, 32);
            Pudding PuddingCzekoladowy = new Pudding("Pudding czekoladowy", 750, 3, "czekoladowy");
            Popcorn MalyPopcorn = new Popcorn("Mały popcorn solony", 700, 2, 90);
            Popcorn DuzyPopcorn = new Popcorn("Duży popcorn solony", 750, 3, 120);
            Muffin MalyMuffinCzekoladowy = new Muffin("Mały muffin czekoladowy", 750, 5, "mały", "czekoladowy");
            Muffin DuzyMuffinCzekoladowy = new Muffin("Duży muffin czekoladowy", 750, 6, "duży", "czekoladowy");


            string Load;

            if (File.Exists("Save.json")) 
            {
                 Load = File.ReadAllText("Save.json");
            }
            else
            {
                 Load = " { \"ListaHistoria\":[]}";
            }


            Historia historia = JsonConvert.DeserializeObject<Historia>(Load);


            Kuchenka kuchenka = new Kuchenka(500, 10, lasagneBolognese,historia);
            kuchenka.ZapiszHistorie();


            kuchenka.ListaLasagne.Add(lasagneBolognese);
            kuchenka.ListaLasagne.Add(lasagneNapoli);
            kuchenka.ListaPizza.Add(MalaMargherita);
            kuchenka.ListaPizza.Add(DuzaMargherita);
            kuchenka.ListaPudding.Add(PuddingCzekoladowy);
            kuchenka.ListaPopcorn.Add(MalyPopcorn);
            kuchenka.ListaPopcorn.Add(DuzyPopcorn);
            kuchenka.ListaMuffin.Add(MalyMuffinCzekoladowy);
            kuchenka.ListaMuffin.Add(DuzyMuffinCzekoladowy);
            kuchenka.Menu();

        }
    }
}