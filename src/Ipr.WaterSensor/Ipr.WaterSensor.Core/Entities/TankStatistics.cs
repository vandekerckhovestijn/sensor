﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipr.WaterSensor.Core.Entities
{
    public class TankStatistics
    {
        //3 tabs per dag maand jaar 
        public int TotalWaterCollected { get; set; }
        public int TotalWaterDispensed { get; set; }
    }
}
