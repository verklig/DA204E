using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    /// <summary>
    /// This class is the file manager that saves or loads text files.
    /// </summary>
    internal class FileManager
    {
        private const string fileVersionToken = "TODOv1"; // Version token for validation
        private const double fileVersionNr = 1.0; // Version number for validation

        /// <summary>
        /// This method saves the task list to a text file.
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns>true or false</returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            StreamWriter writer = null; // StreamWriter object to be used as writer
            bool ok = true; // Bool for validation

            try // Tries the code below
            {
                writer = new StreamWriter(fileName); // New object instance of StreamWriter
                writer.WriteLine(fileVersionToken); // Writes the version token
                writer.WriteLine(fileVersionNr); // Writes the version number
                writer.WriteLine(taskList.Count); // Writes the number of tasks

                for (int i = 0; i < taskList.Count; i++) // For every task, write the info
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].TaskDate.Year);
                    writer.WriteLine(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            }
            catch // Catches any exceptions and returns false if so
            {
                ok = false;
            }
            finally // Always executes this code
            {
                // If writer is empty, close it
                if (writer != null)
                {
                    writer.Close();
                }
            }

            return ok;
        }

        /// <summary>
        /// This method loads the task list to the gui.
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns>true or false</returns>
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            StreamReader reader = null; // StreamReader object to be used as reader
            bool ok = true; // Bool for validation

            try // Tries the code below
            {
                if (taskList != null) // If the task list is empty, clear it
                {
                    taskList.Clear();
                }
                else // If not, create new list
                {
                    taskList = new List<Task>();
                }

                reader = new StreamReader(fileName); // New object instance of StreamReader
                string versionToken = reader.ReadLine(); // Reads the version token
                double versionNr = double.Parse(reader.ReadLine()); // Reads the version number

                if ((versionToken == fileVersionToken) && (versionNr == fileVersionNr)) // If the version token and version number is ok
                {
                    int count = int.Parse(reader.ReadLine()); // Reads the count

                    for (int i = 0; i < count; i++) // For every task, create a new task, read the info and add to the list
                    {
                        Task task = new Task();

                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.TaskDate = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(task);
                    }
                }
                else // If the version token or version number is wrong
                {
                    ok = false;
                }
            }
            catch // Catches any exceptions and returns false if so
            {
                ok = false;
            }
            finally // Always executes this code
            {
                // If reader is empty, close it
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return ok;
        }
    }
}
