using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChallenge
{
    public class Hero
    {
        public Hero() { }

        public Hero(string name, string si, string home, bool isHero, int speed,
            int power, int intelligence)
        {
            HeroName = name;
            SecretIdentity = si;
            HomeTown = home;
            IsHero = IsHero;
            Speed = speed;

            // This only works when constructed, can't ensure after it's made.
            if (power > 100)
                power = 100;
            else if (power < 1)
                power = 1;
            else
                Power = power;
            Intelligence = intelligence;
        }

        internal object Compare(Hero supe)
        {
            throw new NotImplementedException();
        }

        public string HeroName { get; set; }
        public string SecretIdentity { get; set; }
        public string HomeTown { get; set; }
        public bool IsHero { get; set; }

        private int _speed { get; set; }
        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if (value >= 100)
                {
                    if (HeroName == "The Flash") _speed = 100;
                    else
                        _speed = 99;
                }

                else if (value < 1)
                    _speed = 1;
                else
                    _speed = value;
            }
        }


        public int Power 
        { 
            get; 
            set; 
        }
        private int _intelligence { get; set; }
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }

            set
            {
                if (value > 100)
                    _intelligence = 100;
                else if (value < 1)
                    _intelligence = 1;
                else
                    _intelligence = value;
            }
        }

        public string HeroStatus(bool isHero)
        {
            if (isHero)
            {
                return $"{HeroName} is a hero!";
            }
            else
                return $"{HeroName} is a villan";

        }
        // Average Power
        public int AveragePower()
        {
            return (Speed + Power + Intelligence) / 3;
        }

    }




}
