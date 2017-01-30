using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    interface PlaticiStrategie
    {
        string Neco{
        get;set;    
        }


        void Zaplat(Osoba osoba,int cena);
    }
}
