using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Autor:Osoba
    {
        private string narodowosc;

        public Autor()
        {

        }

        public Autor(string imie, string nazwisko, string narodowosc):base(imie, nazwisko)
        {
            this.narodowosc = narodowosc;
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }

        public void UzupelnijAutora(string imie, string nazwisko, string narodowosc_podana)
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            narodowosc = narodowosc_podana;
        }
    }
}
