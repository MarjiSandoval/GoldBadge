using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InterfacesIntroduction.Fruits
{

    //this is a contract that classes implement 
    //Everything is public by default
    //These always start with the letter I (capital)
    public interface IFruit
    {
        string Name { get; }// Property with get;
        bool IsPeeled { get; } // Property with get 
        string Peel(); // method that returns a string.
    }
}
