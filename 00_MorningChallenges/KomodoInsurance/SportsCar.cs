﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges.KomodoInsurance
{
    public class SportsCar : Vehicle
    {
        public SportsCar(string make, string model, string color) :base(make, model, color)
        {
            VehicleType = VehicleType.SportsCar;
        }
    }
}