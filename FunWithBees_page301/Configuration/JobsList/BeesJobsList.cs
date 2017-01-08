using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.JobsList
{
    public static class BeesJobsList
    {
        private static string[] list = new string[]
        {
            "Nectar Collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"
        };

        public static string[] List
        {
            get
            {
                return list;
            }
        }

        public static string[] GetList(int firstIndex, int secondIndex)
        {
            return new string[2] { list[firstIndex], list[secondIndex] };
        }

    }
}
