using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Kuchenka
    {
        public int Moc;
        public int Czas;
        public Danie GotowaneDanie;
        private int opcja;
        public List<Lasagne> ListaLasagne=new List<Lasagne>();
        public List<Pizza> ListaPizza=new List<Pizza>();
        public List<Pudding> ListaPudding=new List<Pudding>();
        public List<Popcorn> ListaPopcorn = new List<Popcorn>();
        public List<Muffin> ListaMuffin = new List<Muffin>();
        public Historia Historia;


        public Kuchenka(int moc, int czas,Danie gotowaneDanie, Historia historia)
        {
            Moc = moc;
            Czas = czas;
            GotowaneDanie = gotowaneDanie;
            Historia = historia;
        }

        public void ZapiszHistorie()
        {
            string Saved = JsonConvert.SerializeObject(Historia);
            File.WriteAllText("Save.json", Saved);
        }

        public void Gotuj()
        {
            if (Moc > 0.8*GotowaneDanie.Moc & Moc < 1.2 * GotowaneDanie.Moc & Czas > 0.8*GotowaneDanie.Czas & Czas < 1.2 * GotowaneDanie.Czas)
            {
                Console.WriteLine("Poprawnie ugotowane");
                Historia.ListaHistoria.Add(new Data(Moc, Czas,GotowaneDanie.Nazwa,"Poprawinie ugotowane"));
            }
            else if (Moc>1.2*GotowaneDanie.Moc || Czas> 1.2 * GotowaneDanie.Czas)
            {
                Console.WriteLine("Spalone");
                Historia.ListaHistoria.Add(new Data(Moc, Czas, GotowaneDanie.Nazwa, "Spalone"));
            }
            else
            {
                Console.WriteLine("Nie ugotowane");
                Historia.ListaHistoria.Add(new Data(Moc, Czas, GotowaneDanie.Nazwa, "Nie ugotowane"));
            }
            ZapiszHistorie();
        }
        private void WyborOpcji()
        {
            try
            {
                opcja = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Wybór opcji musi być liczbą, wrócono do menu głównego");
                Console.WriteLine("");
                Menu();
            }
        }
        public void Menu()
        {
            Console.WriteLine("1.Ustaw moc");
            Console.WriteLine("2.Ustaw czas");
            Console.WriteLine("3.Wybierz danie z listy");
            Console.WriteLine("4.Wyświetl aktualne ustawienia");
            Console.WriteLine("5.Gotuj");
            Console.WriteLine("6.Wyświetl historię gotowania");
            Console.WriteLine("7.Wyczyść historię gotowania");

            WyborOpcji();

            switch (opcja)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Podaj moc:");
                    try
                    {
                        Moc = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Menu();
                    }
                    catch (System.FormatException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Moc musi być liczbą");
                        Console.WriteLine("");
                        Menu();
                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Podaj czas:");
                    try
                    {

                        Czas = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Menu();
                    }
                    catch (System.FormatException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Czas musi być liczbą");
                        Console.WriteLine("");
                        Menu();
                    }

                    break;
                case 3:
                    Console.Clear();
                    FListaDan();
                    Menu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Moc="+Moc);
                    Console.WriteLine("Czas=" + Czas);
                    Console.WriteLine(GotowaneDanie.Nazwa);
                    Console.WriteLine("");
                    Menu();
                    break;
                case 5:
                    Console.Clear();
                    Gotuj();
                    Console.WriteLine("");
                    Menu();
                    break;
                case 6:
                    Console.Clear();
                    for (int i = 0;i<Historia.ListaHistoria.Count; i++)
                    {
                        Console.WriteLine(i+1+".");
                        Historia.ListaHistoria[i].Wypisz();
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Menu();
                    break;
                case 7:
                    Historia.ListaHistoria.Clear();
                    Console.Clear();
                    ZapiszHistorie();
                    Menu();
                    break;

            }
        }
        private void FListaLasagne()
        {
            Console.Clear();
            for (int i = 0; i < ListaLasagne.Count; i++)
            {
                Console.WriteLine(i+1+".");
                ListaLasagne[i].Wypisz();
                Console.WriteLine("");
            }
            WyborOpcji();
            try
            {
                GotowaneDanie = ListaLasagne[opcja - 1];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                FListaLasagne();
            }
            Console.Clear();
        }

        private void FListaPizza()
        {
            Console.Clear();
            for (int i = 0; i < ListaPizza.Count; i++)
            {
                Console.WriteLine(i + 1 + ".");
                ListaPizza[i].Wypisz();
                Console.WriteLine("");
            }
            WyborOpcji();
            try
            {
                GotowaneDanie = ListaPizza[opcja - 1];
            }
            catch(System.ArgumentOutOfRangeException ex)
            {
                FListaPizza();
            }
            Console.Clear();
        }

        private void FListaPudding()
        {
            Console.Clear();
            for (int i = 0; i < ListaPudding.Count; i++)
            {
                Console.WriteLine(i + 1 + ".");
                ListaPudding[i].Wypisz();
                Console.WriteLine("");
            }
            WyborOpcji();
            try
            {
                GotowaneDanie = ListaPudding[opcja - 1];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                FListaPudding();
            }
            Console.Clear();
        }

        private void FListaPopcorn()
        {
            Console.Clear();
            for (int i = 0; i < ListaPopcorn.Count; i++)
            {
                Console.WriteLine(i + 1 + ".");
                ListaPopcorn[i].Wypisz();
                Console.WriteLine("");
            }
            WyborOpcji();
            try
            {
                GotowaneDanie = ListaPopcorn[opcja - 1];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                FListaPopcorn();
            }
            Console.Clear();
        }

        private void FListaMuffin()
        {
            Console.Clear();
            for (int i = 0; i < ListaMuffin.Count; i++)
            {
                Console.WriteLine(i + 1 + ".");
                ListaMuffin[i].Wypisz();
                Console.WriteLine("");
            }
            WyborOpcji();
            try
            {
                GotowaneDanie = ListaMuffin[opcja - 1];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                FListaMuffin();
            }
            Console.Clear();
        }
        private void FListaDan()
        {
            Console.WriteLine("1.Lasagne");
            Console.WriteLine("2.Pizza");
            Console.WriteLine("3.Pudding");
            Console.WriteLine("4.Popcorn");
            Console.WriteLine("5.Muffin");
            WyborOpcji();

            switch (opcja)
            {
                case 1:
                    FListaLasagne();
                    break;
                case 2:
                    FListaPizza();
                    break;
                case 3:
                    FListaPudding();
                    break;
                case 4:
                    FListaPopcorn();
                    break;
                case 5:
                    FListaMuffin();
                    break;
            }

        }
    }
}
