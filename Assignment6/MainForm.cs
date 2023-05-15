using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        private string fileName;
        private TaskManager taskMngr;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            foreach (PriorityType priority in Enum.GetValues(typeof(PriorityType)))
            {
                cmbPriority.Items.Add(priority.ToString().Replace("_", " "));
            }
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            txtTask.Clear();
            lstTask.Items.Clear();

            MaximizeBox = false;
            txtTask.MaxLength = 24;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool taskOK = ReadTask();

            if (taskOK)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lstTask_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {

        }

        private void ReadDate()
        {
            
        }

        private void ReadPriority()
        {
            
        }

        private bool ReadTask()
        {
            Task task = new Task();
            string taskText = txtTask.Text.Trim();

            bool ok = ValidateTask();

            if (ok)
            {
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
