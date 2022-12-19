using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo
{
    public partial class InstructorDashboard : Form
    {
        public InstructorDashboard()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();

            }
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            InstructorDashboardPanel.Show();
            InstructorStudentPanel.Hide();
            ValidatePanel.Hide();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            InstructorDashboardPanel.Hide();
            InstructorStudentPanel.Show();
            ValidatePanel.Hide();
        }

        private void ValidateBTN_Click(object sender, EventArgs e)
        {
            InstructorDashboardPanel.Hide();
            InstructorStudentPanel.Hide();
            ValidatePanel.Show();
        }
    }
}
