using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    public interface ITypPrisery
    {
        int hodnotaUtoku { get; set; }
        string nazev { get; set; }
        int zivoty { get; set; }
    }
}
