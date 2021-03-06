﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.BeeHive
{
    public class Worker
        : Base.Bee
    {
        string[] jobsICanDo;
        int shiftsToWork;
        int shiftsWorked;

        string currentJob = string.Empty;
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public Worker(string[] jobsICanDo, double weightMg)
            : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;
            if(jobsICanDo.Contains(job))
            {
                currentJob = job;
                shiftsToWork = numberOfShifts;
                shiftsWorked = 0;
                return true;
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                currentJob = string.Empty;
                shiftsToWork = 0;
                shiftsWorked = 0;
                return true;
            }
            else
                return false;
        }

        public override double HoneyConsumptionRate()
        {
            //double result = base.HoneyConsumptionRate();
            //result += shiftsWorked * .65;
            //return result;
            return base.HoneyConsumptionRate() + shiftsWorked * .65;
        }
    }
}
