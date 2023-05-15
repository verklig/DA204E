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

        public DateTime DateAndTime { get { return date; } set { date = value; } }
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
            return null;
        }

        private string GetTimeString()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
