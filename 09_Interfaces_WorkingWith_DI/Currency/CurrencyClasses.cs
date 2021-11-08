using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWith_DI.Currency
{

    public class Penny : ICurrency
    {
        public decimal Value =>.01m;

        public string Name => "Penny";
    }
    public class Dime : ICurrency
    {
        public string Name
        {
            get
            {
                return "Dime";
            }
        }
        public decimal Value
        {
            get
            {
                return .1m;
            }
        }
    }
    public class Dollar : ICurrency
    {
        public decimal Value
        {
            get
            {
                return 1m;
            }
        }
        public string Name
        {
            get
            {
                return "Dollar";
            }
        }
    }
    public class ElectronicPayment : ICurrency
    {
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
        //this is subject to change
        public decimal Value { get; }

        public string Name => "Electronic Payment";
    }
}
