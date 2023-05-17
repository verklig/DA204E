using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Task
    {
        private DateTime date;
        private string description;
        private PriorityType priority;

        // public DateTime DateAndTime { get { return date; } set { date = value; } } 
        public DateTime TaskDate { get { return date; } set { date = value; } }
        public PriorityType Priority { get { return priority; } set { priority = value; } }
        public string Description { get { return description; } set { description = value; } }

        public Task()
        {
            priority = PriorityType.Normal;
        }

        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {
        }

        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            date = taskDate;
            this.description = description;
            this.priority = priority;
        }

        public string GetPriorityString()
        {
            string priority = Enum.GetName(typeof(PriorityType), this.priority);
            priority = priority.Replace("_", " ");

            return priority;
        }

        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}", date.Hour.ToString("00"), date.Minute.ToString("00"));

            return time;
        }

        public override string ToString()
        {
            string txtOut = $"{date.ToLongDateString(),-25} {GetTimeString(),-12} {" ",5}" +
                            $"{GetPriorityString(),-19} {description}";

            return txtOut;
        }
    }
}
