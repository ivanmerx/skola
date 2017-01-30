using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class CzkToDollarExchangeStrategy : IExchangeStrategy
    {
        private double hodnota = 25.6;

        public double Exchange(BankAccount bankacc)
        {
            return bankacc.AccountBallance / hodnota;
        }
    }
}
