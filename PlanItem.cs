using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public class PlanItem
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private Point totime;
        public Point ToTime
        {
            get { return totime; }
            set { totime = value; }
        }
        public string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        private Point fromtime;
        public Point FromTime
        {
            get { return fromtime; }
            set { fromtime = value; }

        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public static List<string> ListStatus = new List<string> { "DONE", "DOING", "COMING", "MISSING" };
    }
    public enum EPlanItem
    {
        DONE,
        DOING,
        COMING,
        MISSING
    }
}
