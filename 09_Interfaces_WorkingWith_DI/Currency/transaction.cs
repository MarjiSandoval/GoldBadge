using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWith_DI.Currency
{
    public class Transaction
    {

        // private backing field that will hold the data (ICurrency0that is passed in 'when ever this is created'
        private readonly ICurrency _currency;


        //this ICurrency currency => cones from and outside source
        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }


        //this gives us the date when the transaction occured.
        public DateTimeOffset DateOfTransaction { get; private set; }

        //Custom method

        //once this method is called
        //we take the information from _currency, which is stored upon Transaction (the class) creation
        public decimal GetTransactionAmount()
        {
            return _currency.Value;

        }

        public ICurrency ReturnMyType()
        {
            return _currency;
        }

        //Get transaction type
        public string GetTransactionType() => _currency.Name;
    }


}
