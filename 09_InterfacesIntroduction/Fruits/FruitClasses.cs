using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InterfacesIntroduction.Fruits
{
    
        //this is the implementation of IFruit
    public class Banana : IFruit
    {
        public Banana()
        {
        }

        // we can change the private set here because
        //the constructor allows us to. but, only
        //the constructor will let this happen.
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }
        // We are using the private set to make sure that we 
        //can only change 'IsPeeled' via a method that lives on this class.
        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana.";
        }
    }
    public class Orange : IFruit
    {
        public Orange()
        {
        }

        public Orange(bool isPeeled)
        {
            bool IsPeeled = isPeeled;
        }
        public string Name => "Orange";

        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel and Orange.";
        }

        //Classes that implement the interface can still have their own methods.
        public string Squeeze()
        {
            return "You squeeze the Orange and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public Grape()
        {

        }
        public Grape(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Grape";
            }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}
