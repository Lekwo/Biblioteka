﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    interface IZarzadzanie
    {
        void WypiszWszystko();
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
    }
}
