using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Monstra;

namespace WpfApplication1.Monstra
{
    class UtokNohama : typBoje
    {
        int hodnotaSily = 10;

        int typBoje.hodnotaSily
        {
            get
            {
               return  hodnotaSily;
            }

            set
            {
                hodnotaSily = value;
            }
        }

        public void sejmoutPriseru()
        {
            throw new NotImplementedException();
        }
    }

}
