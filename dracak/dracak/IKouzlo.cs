using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dracak.Kouzla;
namespace dracak
{
    public interface IKouzlo
    {
        int hodnotaUtoku { get; set; }
        string nazev { get; set; }
        int plusZivoty { get; set; }
    }
}
