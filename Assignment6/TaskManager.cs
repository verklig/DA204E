using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    /// <summary>
    /// This class is the manager for the tasks, it adds or changes the tasks if the values are valid.
    /// </summary>
    internal class TaskManager
    {
        List<Task> taskList = new List<Task>(); // List of tasks

        // Getter for task count
        public int TaskCount { get { return taskList.Count; } }

        /// <summary>
        /// The constructor of the class creating a new list.
        /// </summary>
        public TaskManager() 
        {
            taskList = new List<Task>();
        }

        /// <summary>
        /// This method gets the task at the chosen index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the chosen task</returns>
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

        /// <summary>
        /// This method adds a task to the task list if the input is ok.
        /// </summary>
        /// <param name="task"></param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// This method edits the chosen task.
        /// </summary>
        /// <param name="task"></param>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// This method deletes the chosen task.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// This method writes data to the file to be saved if the validation is ok.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>true or false</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileMngr = new FileManager();

            return fileMngr.SaveTaskListToFile(taskList, fileName);
        }

        /// <summary>
        /// This method reads data from the file to be opened if the validation is ok.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>true or false</returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileMngr = new FileManager();

            return fileMngr.ReadTaskListFromFile(taskList, fileName);
        }
    }
}
