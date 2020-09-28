﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessLayer.Bus
{
    public interface IMovable
    {
        double GetMaxSpeed();
        void SpeedUp(double newSpeed);
    }
}

