using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWith_DI.Currency
{
    //Dependency Injection (DI) allows us to have loosely coupled code.
    //Its something that's required or something your code depends on.
    //by injecting from the outside it makes life easier.

    public interface ICurrency
    {
        // currency worth
        decimal  Value { get; }
        //currency name
        string Name { get; }
    }
}
