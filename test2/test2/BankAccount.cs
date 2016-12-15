using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class BankAccount
    {
        double accountBallance;
        IExchangeStrategy exchangeStrategy;
        public double AccountBallance
        {
            get
            {
                return accountBallance;
            }

            set
            {
                accountBallance = value;
            }
        }
        public IExchangeStrategy ExchangeStrategy
        {
            get
            {
                return exchangeStrategy;
            }
            set
            {
                exchangeStrategy = value;
            }
        }
        public double Convert()
        {
            return ExchangeStrategy.Exchange(this);
        }
    }
}
