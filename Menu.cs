using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja_16_12_2017_Najnowsza
{
    public class Menu:Iwyswietlanie,IdodajPozycjeMenu
    {
        public string[] NazwaGlownego = { "SCHABOWY", "PIEROGI", "NALESNIKI", "SPAGHETTI", "LAZANIA" };
        public double[] CenaGlownego = { 15.99, 12.99, 13.0, 19.99, 24.5 };
        public string[] NazwaZupy = {"Rosol", "Pieczarkowa", "Pomidorowa" };
        public double[] CenaZupy = {5.99, 8.99, 5.99 };
        public string[] Desery = { "Lody", "Mascarpone", "Szarlotka", "Makowiec" };
        public double[] Cenadesery = { 10.99, 5.99, 5.99, 3.99 };
        public void wyswietlmenu()
        {
            Console.WriteLine();
            Console.WriteLine("DANIE GLOWNE" + "   " + "CENA DANIA GLOWNEGO");
            for(int i=0;i<NazwaGlownego.Length;i++)
            {
                Console.WriteLine("Numer:" + " "+ i + "     "+ NazwaGlownego[i] + "             " + CenaGlownego[i]);               
            }
            Console.WriteLine();
            Console.WriteLine("ZUPY" + "             " + "CENA ZUPY");
            for (int i = 0; i < NazwaZupy.Length; i++)
            {
                Console.WriteLine("Numer:" + " " + i + "     " + NazwaZupy[i] + "        " + CenaZupy[i]);
            }
            Console.WriteLine();
            Console.WriteLine("DESERY" + "             " + "CENA DESERU");
            for (int i = 0; i < Desery.Length; i++)
            {
                Console.WriteLine("Numer:" + " " + i + "     " + Desery[i] + "        " + Cenadesery[i]);
            }

        }
        public void dodajglowne(string nazwa,double cena)
        { 
            int rozmiar = NazwaGlownego.Length;
            Array.Resize(ref NazwaGlownego, rozmiar + 1);
            NazwaGlownego[rozmiar] = nazwa;
            Array.Resize(ref CenaGlownego, rozmiar + 1);
            CenaGlownego[rozmiar] = cena;
        }

        public void dodajzupe(string nazwa, double cena)
        {
            int rozmiar = NazwaZupy.Length;
            Array.Resize(ref NazwaZupy, rozmiar + 1);
            NazwaZupy[rozmiar] = nazwa;
            Array.Resize(ref CenaZupy, rozmiar + 1);
            CenaZupy[rozmiar] = cena;
        }

        public void dodajdeser(string nazwa, double cena)
        {
            int rozmiar = Desery.Length;
            Array.Resize(ref Desery, rozmiar + 1);
            Cenadesery[rozmiar] = cena;
            Array.Resize(ref Cenadesery, rozmiar + 1);
            Cenadesery[rozmiar] = cena;
        }
    }
}
