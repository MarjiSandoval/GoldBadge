using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges.KomodoInsurance
{
    public interface IVehicle
    {
        string Color { get; set; }
        string Model { get; set; }
        string Make { get; set; }
        void TurnOn();
        void TurnOff();

        void Drive();
    }
}
