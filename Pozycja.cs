using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Wydawnictwo
        {
            get { return wydawnictwo; }
            set { wydawnictwo = value; }
        }

        public int RokWydania
        {
            get { return rokWydania; }
            set { rokWydania = value; }
        }



        public Pozycja()
        {

        }

        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Tytul :{0}", Tytul);
            Console.WriteLine("ID : {0}", Id);
            Console.WriteLine("Wydawnictwo : {0}", Wydawnictwo);
            Console.WriteLine("Rok wydania : {0}", RokWydania);
        }

        public string PobierzTytul()
        {
            return tytul;
        }

        public int PobierzId()
        {
            return id;
        }
    }
}
