using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Katalog
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, string imie, string nazwisko, string narodowosc)
        {
            pozycje.Add(new Pozycja() { Tytul=tytul, Id=id, Wydawnictwo=wydawnictwo, RokWydania=rokWydania, /*(imie=imie, nazwisko=nazwisko, narodowosc=narodowosc*/});
        }
        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            pozycje.Add(new Pozycja() { Tytul=tytul, Id=id, Wydawnictwo=wydawnictwo, RokWydania=rokWydania, /*numer=numer*/ });
        }

        public void WypiszWszystko()
        {
            foreach(Pozycja pozycja in pozycje)
            {
                Console.WriteLine(pozycja);
            }
        }
    }
}
