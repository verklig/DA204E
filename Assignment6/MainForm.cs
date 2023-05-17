using Assignment5;
using Assignment6.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        private TaskManager taskMngr;
        private Task task;
        private string fileName;
        private bool isEditing = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

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

            dateTimePicker.CustomFormat = "yyyy-MM-dd    HH:mm";

            foreach (PriorityType priority in Enum.GetValues(typeof(PriorityType)))
            {
                cmbPriority.Items.Add(priority.ToString().Replace("_", " "));
            }

            SetDefaultValues();
        }

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

        private void SetDefaultValues()
        {
            dateTimePicker.Value = DateTime.Now;
            cmbPriority.SelectedIndex = 2;
            lstTask.Enabled = true;
            menuFile.Enabled = true;
            btnAdd.Text = "Add";
            txtTask.Clear();
        }

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
                    SetDefaultValues();
                }
            }
            else
            {
                if (inputOK)
                {
                    taskMngr.AddTask(task);
                    lstTask.SelectedIndex = -1;

                    UpdateTaskList();
                    SetDefaultValues();
                }
            }
        }

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
                        lblEditing.Visible = true;
                        btnAdd.Text = "Finish";

                        dateTimePicker.Value = task.TaskDate;
                        cmbPriority.SelectedIndex = (int)task.Priority;
                        txtTask.Text = task.Description;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstTask.SelectedIndex;

            if (index >= 0)
            {
                taskMngr.DeleteTask(index);
                lstTask.SelectedIndex = -1;
                UpdateTaskList();
            }
        }

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

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {

        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {

        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            CustomMessageForm dlg = new CustomMessageForm();
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            CustomMessageForm dlg = new CustomMessageForm();
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

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

        private bool ValidateTask()
        {
            bool taskOK = true;

            if (txtTask.Text == "")
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
