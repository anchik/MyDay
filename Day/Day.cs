using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay
{
    public class Day
    {
        public const string CorrectWakeUpTimeMessage = "Good morning!";
        public const string LateWakeUpTimeMessage = "Too late!";

        DateTime? requiredWakeUpTime;
        DateTime actualWakeUpTime;

        public DateTime Date { get; set; }
        public DateTime? RequiredWakeUpTime { get { return requiredWakeUpTime; } }
        public DateTime ActualWakeUpTime { get { return actualWakeUpTime; } }

        public Day()
        {
            Date = DateTime.Now.Date;
        }

        public Day(DateTime date)
        {
            Date = date.Date;
        }

        public void SetRequiredWakeUpTime(int hour, int minute)
        {
            requiredWakeUpTime = new DateTime(Date.Year, Date.Month, Date.Day, hour, minute, 0);
        }

        public string WakeUp(int hour, int minute)
        {
            actualWakeUpTime = new DateTime(Date.Year, Date.Month, Date.Day, hour, minute, 0);

            if (actualWakeUpTime <= requiredWakeUpTime||requiredWakeUpTime==null) return CorrectWakeUpTimeMessage;
            else return LateWakeUpTimeMessage;
        }


    }
}
