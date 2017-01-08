using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.BeeHive
{
    public class Queen
    {
        Worker[] workers;
        int shiftNumber = 0;

        public Queen (Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork( string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Отчет для смены#" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += StartOfReportLine(i) + " закончил работу\r\n";

                report += StartOfReportLine(i);
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += " не работает\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        report += $" выполняет '{workers[i].CurrentJob}' еще {workers[i].ShiftsLeft} смен\r\n";
                    else
                        report += $" закончит '{workers[i].CurrentJob}' после этой смены\r\n";
                }

            }

            return report;
        }

        string StartOfReportLine(int i)
        {
            return $"Рабочий #{i + 1}";
        }

    }
}
