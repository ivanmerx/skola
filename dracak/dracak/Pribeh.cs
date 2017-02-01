using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace dracak
{
    class Pribeh
    {
        private List<VytvorPage> pribehy = new List<VytvorPage>();

        public VytvorPage Pridat(VytvorPage pribeh)
        {
 
            pribehy.Add(pribeh);
            return pribehy.Last();
        }
        public VytvorPage vypis()
        {
            return pribehy.First();
        }
    }
}
