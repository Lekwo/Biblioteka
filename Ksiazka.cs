using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Ksiazka:Pozycja
    {
        private int LiczbaStron;
        private Autor autor= new Autor();

        public Ksiazka()
        {

        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, string imie, string nazwisko, string narodowosc):base(tytul,id,wydawnictwo,rokWydania)
        {
            autor.UzupelnijAutora(imie, nazwisko, narodowosc);
        }

    }
}
