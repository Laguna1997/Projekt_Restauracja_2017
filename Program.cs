using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja_16_12_2017_Najnowsza
{
    class Program
    {
        static void Main(string[] args)
        {
            int dzialanie;
            Console.WriteLine("Witaj w naszej Restauracji");
            Menu menu = new Menu();
            Zamowienie zamowienie = new Zamowienie();
        do
        {

            Console.WriteLine("Jakie działanie chcesz wykonać ? ");
            Console.WriteLine("1. Skompletuj nowe zamowienie");
            Console.WriteLine("2. Drukuj rachunek");
            Console.WriteLine("3. Dodaj nowe danie glowne do listy dan");
            Console.WriteLine("4. Dodaj nowa zupe do listy zup");
            Console.WriteLine("5. Dodaj nowy deser do listy deserow");
            Console.WriteLine("6. WYJSCIE");
            dzialanie = Convert.ToInt32(Console.ReadLine());
    
                switch (dzialanie)
                {
                    case 1:
                        menu.wyswietlmenu();

                        zamowienie.Dodaj();
                        zamowienie.Rachunek();
                        break;
                    case 2:
                        zamowienie.Rachunek();
                        break;
                    case 3:
                        string nazwadania;
                        double cenadania;
                        Console.WriteLine("Podaj nazwe dania ktore chcesz dodać");
                        nazwadania = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Podaj cene tego dania");
                        cenadania = Double.Parse(Console.ReadLine());
                        menu.dodajglowne(nazwadania, cenadania);
                        break;
                    case 4:
                        string nazwazupy;
                        double cenazupy;
                        Console.WriteLine("Podaj nazwe zupy ktora chcesz dodać");
                        nazwazupy = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Podaj cene tej zupy");
                        cenazupy = Double.Parse(Console.ReadLine());
                        menu.dodajzupe(nazwazupy, cenazupy);
                        break;
                    case 5:
                        string nazwadeseru;
                        double cenadeseru;
                        Console.WriteLine("Podaj nazwe deseru ktory chcesz dodac do menu");
                        nazwadeseru = Convert.ToString(Console.ReadLine());
                        cenadeseru = Double.Parse(Console.ReadLine());
                        menu.dodajdeser(nazwadeseru, cenadeseru);
                        break;
                    case 6:
                        Console.WriteLine("WYBRALES WYJSCIE Z APLIKACJI");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("WYBRALES WYJSCIE Z APLIKACJI");
                        break;
                }
                Console.WriteLine();
        }
        while (dzialanie != 6);
            Console.WriteLine("Dziekujemy za uzycie naszej aplikacji");


            Console.ReadKey();
        }
    }
}
