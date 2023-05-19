using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class TaskManager
    {
        List<Task> taskList = new List<Task>();

        public int TaskCount { get { return taskList.Count; } }

        public TaskManager() 
        {
            taskList = new List<Task>();
        }

        public Task GetTask(int index)
        {
            if (CheckIndex(index))
            {
                return taskList[index];
            }
            else
            { 
                return null; 
            }
        }

        /// <summary>
        /// This method checks so that the index is within the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < taskList.Count);

            return ok;
        }

        public bool AddTask(Task task)
        {
            bool ok = true;

            if (task != null)
            {
                taskList.Add(task);
            }
            else
            {
                ok = false;
            }

            return ok;
        }

        //public bool AddTask(DateTime date, string description, PriorityType priority)
        //{
        //    Task task = new Task(date, description, priority);
        //    bool ok = true;

        //    if (task != null)
        //    {
        //        taskList.Add(task);
        //    }
        //    else
        //    {
        //        ok = false;
        //    }

        //    return ok;
        //}

        public bool EditTask(Task task, int index)
        {
            bool ok = true;

            if (task != null && CheckIndex(index))
            {
                taskList[index] = task;
            }
            else
            {
                ok = false;
            }

            return ok;
        }

        public bool DeleteTask(int index)
        {
            bool ok = false;

            if (CheckIndex(index))
            {
                taskList.RemoveAt(index);
                ok = true;
            }
            else
            {
                ok = false;
            }

            return ok;
        }

        //public string[] GetInfoStringList()
        //{
        //    string[] infoStrings = new string[taskList.Count];

        //    for (int i = 0; i < infoStrings.Length; i++)
        //    {
        //        infoStrings[i] = taskList[i].ToString();
        //    }

        //    return infoStrings;
        //}

        public bool WriteDataToFile(string fileName)
        {
            FileManager fileMngr = new FileManager();

            return fileMngr.SaveTaskListToFile(taskList, fileName);
        }

        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileMngr = new FileManager();

            return fileMngr.ReadTaskListFromFile(taskList, fileName);
        }
    }
}
