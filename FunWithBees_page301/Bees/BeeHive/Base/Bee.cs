﻿using Configuration.JobsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.BeeHive.Base
{
    public class Bee
    {
        public double honeyUnitsConsumedPerMg = HoneyUnitsConsumedPerMg.Value;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * honeyUnitsConsumedPerMg;
        }
    }
}
