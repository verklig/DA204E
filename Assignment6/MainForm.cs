using Assignment5;
using Assignment6.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Assignment6
{
    /// <summary>
    /// This program is a TODO reminder that the user can use to store different tasks. It allows users to add, edit, and delete tasks and also save and load them.
    /// The program has a GUI that includes a listbox to show a list of tasks, a main menu to choose different options and the various input boxes.
    /// </summary>
    public partial class MainForm : Form
    {
        private TaskManager taskMngr; // Setting the TaskManager class to be used as taskMngr
        private Task task; // Setting the Task class to be used as task
        private string fileName = Application.StartupPath + "\\Tasks.txt"; // Setting file location to Tasks.txt in the same location as the application
        private bool isEditing = false; // Boolean to check if the user is editing or not to keep track of the add button and other things for editing

        /// <summary>
        /// The default constructor of the class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// This method initializes the gui elements and sets different properties for the form at program start.
        /// </summary>
        private void InitializeGUI()
        {
            // Creating a new object of the TaskManager class every time this method runs so that it acts as a new file
            taskMngr = new TaskManager();

            cmbPriority.Items.Clear();
            lstTask.Items.Clear();
            lblEditing.Visible = false;
            EnableButtons(false);

            MaximizeBox = false;
            txtTask.MaxLength = 56;

            toolTip.SetToolTip(dateTimePicker, "Click to open calendar to edit the date, or write directly here.");
            dateTimePicker.CustomFormat = "yyyy-MM-dd    HH:mm";

            foreach (PriorityType priority in Enum.GetValues(typeof(PriorityType)))
            {
                cmbPriority.Items.Add(priority.ToString().Replace("_", " "));
            }

            ResetDefaultValues();
            StartTimer();
        }

        /// <summary>
        /// This method updates the items in the list box.
        /// </summary>
        private void UpdateTaskList()
        {
            lstTask.Items.Clear();

            int amtTasks = taskMngr.TaskCount;

            for (int index = 0; index < amtTasks; index++)
            {
                Task task = taskMngr.GetTask(index);
                lstTask.Items.Add(task.ToString());
            }
        }

        /// <summary>
        /// This method enables or disables the buttons according to the setting parameter.
        /// </summary>
        /// <param name="setting"></param>
        private void EnableButtons(bool setting)
        {
            btnEdit.Enabled = setting;
            btnDelete.Enabled = setting;
        }

        /// <summary>
        /// This method resets most of the components on the gui to the standard values.
        /// </summary>
        private void ResetDefaultValues()
        {
            dateTimePicker.Value = DateTime.Now;
            cmbPriority.SelectedIndex = 2;
            lstTask.Enabled = true;
            menuFile.Enabled = true;
            menuHelp.Enabled = true;
            btnAdd.Text = "Add";
            txtTask.Clear();
        }

        /// <summary>
        /// This method starts the clock to be displayed on the form.
        /// </summary>
        private void StartTimer()
        {
            timer = new Timer();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        /// <summary>
        /// This method is tied to the method above to start the timer object, it
        /// sets todays time on to a label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// This method is for when the user clicks the "Add" or "Finish" button,
        /// it handles reading and validating the input, if the input is ok
        /// it also adds it in the list and updates the ui, it prints an error
        /// if the input was not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            task = new Task();

            bool inputOK = ReadInput();

            if (isEditing)
            {
                if (inputOK)
                {
                    taskMngr.EditTask(task, lstTask.SelectedIndex);
                    lstTask.SelectedIndex = -1;
                    lblEditing.Visible = false;
                    isEditing = false;

                    UpdateTaskList();
                    ResetDefaultValues();
                }
            }
            else
            {
                if (inputOK)
                {
                    taskMngr.AddTask(task);
                    lstTask.SelectedIndex = -1;

                    UpdateTaskList();
                    ResetDefaultValues();
                }
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Edit" button.
        /// It gives back all the information stored in the task list to the various input methods
        /// so that the user can edit the task after one has been made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTask.SelectedIndex != -1)
            {
                int index = lstTask.SelectedIndex;

                if (index >= 0)
                {
                    task = taskMngr.GetTask(index);

                    if (task != null)
                    {
                        isEditing = true;

                        EnableButtons(false);
                        lstTask.Enabled = false;
                        menuFile.Enabled = false;
                        menuHelp.Enabled = false;
                        lblEditing.Visible = true;
                        btnAdd.Text = "Finish";

                        dateTimePicker.Value = task.TaskDate;
                        cmbPriority.SelectedIndex = (int)task.Priority;
                        txtTask.Text = task.Description;
                    }
                }
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Delete" button.
        /// It deletes the currently selected task and clears the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstTask.SelectedIndex;

            if (index >= 0)
            {
                CustomMessageForm dlg = new CustomMessageForm("Delete task", "Are you sure you want to delete the task?" +
                                                                  Environment.NewLine + "This choice cannot be reversed!");
                DialogResult dlgResult = dlg.ShowDialog();

                if (dlgResult == DialogResult.Yes)
                {
                    taskMngr.DeleteTask(index);
                    lstTask.SelectedIndex = -1;
                    UpdateTaskList();
                }
            }
        }

        /// <summary>
        /// This method is called every time the user clicks different items in the list.
        /// It checks if the user has an item selected, if so the "Edit" and "Delete" buttons
        /// become clickable, otherwise they become not clickable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTask.SelectedIndex >= 0)
            {
                EnableButtons(true);
            }
            else
            {
                EnableButtons(false);
            }
        }

        /// <summary>
        /// This method checks if keys are pressed on the keyboard, and if
        /// the combination is ctrl+n it makes a new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                menuFileNew_Click(sender, e);
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "New" button.
        /// It creates a new file because it calls "InitializeGUI();" which
        /// creates a new TaskManager object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            CustomMessageForm dlg = new CustomMessageForm("New file", "Are you sure you want a new file?" +
                                                    Environment.NewLine + "Unsaved progress will be lost!");
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.Yes)
            {
                InitializeGUI();
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Open data file" button.
        /// It opens the "Tasks.txt" file if it exists and loads the data to the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            bool ok = taskMngr.ReadDataFromFile(fileName);

            if (!ok)
            {
                CustomMessageForm dlg = new CustomMessageForm("Error", "Could not open data file!" +
                                            Environment.NewLine + "Unknown reason...", false, "OK");
                DialogResult dlgResult = dlg.ShowDialog();
            }
            else
            {
                UpdateTaskList();
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Save data file" button.
        /// It saves the data to the "Tasks.txt" file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            bool ok = taskMngr.WriteDataToFile(fileName);

            if (!ok)
            {
                CustomMessageForm dlg = new CustomMessageForm("Error", "Could not save data file!" +
                                            Environment.NewLine + "Unknown reason...", false, "OK");
                DialogResult dlgResult = dlg.ShowDialog();
            }
            else
            {
                CustomMessageForm dlg = new CustomMessageForm("File saved!", "Data file saved to:" + Environment.NewLine + fileName, false, "OK");
                DialogResult dlgResult = dlg.ShowDialog();
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Exit" button.
        /// It closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method is for when the user clicks the "About" button.
        /// It opens an about box diplaying info about the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog();
        }

        /// <summary>
        /// This method is called when the program is closing, it gives a prompt if you want
        /// to exit or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomMessageForm dlg = new CustomMessageForm("Exit program", "Are you sure you want to exit?" +
                                                     Environment.NewLine + "Unsaved progress will be lost!");
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// This method reads the input and validates them
        /// and also sends a boolean that is either true or false depening on the validation.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ReadInput()
        {
            string taskText = txtTask.Text.Trim();

            bool ok = ValidateTask();

            if (ok)
            {
                task.TaskDate = dateTimePicker.Value;
                task.Priority = (PriorityType)cmbPriority.SelectedIndex;
                task.Description = taskText;
            }

            return ok;
        }

        /// <summary>
        /// This method validates the task input so that you can't leave
        /// empty spaces or nothing in the task description.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateTask()
        {
            bool taskOK = true;

            if (String.IsNullOrWhiteSpace(txtTask.Text))
            {
                errorTask.SetError(txtTask, "Please add a task description");
                taskOK = false;
            }
            else
            {
                errorTask.SetError(txtTask, "");
            }

            return taskOK;
        }
    }
}
