using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n### Zadanie 1 ###\n");

            var o = new Osoba("Adam", "Miś", "20.03.1980");
            var o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            var o3 = new Pilkarz("Mateusz", "Żbik", "20.03.1980", "obrońca", "FC Czestochowa");

            o.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();

            var s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            var p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

            s.WypiszInfo();
            p.WypiszInfo();

            ((Pilkarz)o3).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o3.WypiszInfo();
            p.WypiszInfo();

        }
    }
}
