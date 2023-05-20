using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    /// <summary>
    /// This class temporarily saves data to be sent to the list in the "TaskManager" class.
    /// </summary>
    internal class Task
    {
        private DateTime date; // Date object
        private PriorityType priority; // Priority object
        private string description; // Description as a string

        // Getter and setters
        public DateTime TaskDate { get { return date; } set { date = value; } }
        public PriorityType Priority { get { return priority; } set { priority = value; } }
        public string Description { get { return description; } set { description = value; } }

        /// <summary>
        /// The constructor of the class.
        /// </summary>
        public Task()
        {
            priority = PriorityType.Normal;
        }

        /// <summary>
        /// This method gets the priority string.
        /// </summary>
        /// <returns>priority as a string</returns>
        public string GetPriorityString()
        {
            string priority = Enum.GetName(typeof(PriorityType), this.priority);
            priority = priority.Replace("_", " ");

            return priority;
        }

        /// <summary>
        /// This method gets the formatted time string.
        /// </summary>
        /// <returns>time as a formatted string</returns>
        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}", date.Hour.ToString("00"), date.Minute.ToString("00"));

            return time;
        }

        /// <summary>
        /// This method overrides the "ToString()" method to return a formatted string
        /// that displays the date and time, priority and description to the list.
        /// </summary>
        /// <returns>date and time, priority and description as a string</returns>
        public override string ToString()
        {
            string txtOut = $"{date.ToShortDateString(),-25} {GetTimeString(),-12} {" ",5}" +
                            $"{GetPriorityString(),-19} {description}";

            return txtOut;
        }
    }
}
