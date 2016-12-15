using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankacc = new BankAccount();
            bankacc.AccountBallance = 10000;
            bankacc.ExchangeStrategy = new CzkToDollarExchangeStrategy();
            Console.WriteLine(bankacc.Convert());
            bankacc.ExchangeStrategy = new CzkToEuroExchangeStrategy();
            Console.WriteLine(bankacc.Convert());

        }
    }
}
