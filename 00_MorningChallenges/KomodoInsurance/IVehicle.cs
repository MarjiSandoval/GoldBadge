using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges.KomodoInsurance
{
    public interface IVehicle
    {
        string Color();
        string Model();
        string Make();
        bool IsRunning();
        bool IsMoving();
    }
}
