using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Monstra
{
    class UtokPestmi : typBoje
    {
        int hodnotaSily = 30;
        int typBoje.hodnotaSily
        {
            get
            {
                return hodnotaSily;
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
