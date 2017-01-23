using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dracak
{
    interface IKouzlo
    {
        int hodnotaUtoku { get; set; }
        string nazev { get; set; }
        int plusZivoty { get; set; }
    }
}
