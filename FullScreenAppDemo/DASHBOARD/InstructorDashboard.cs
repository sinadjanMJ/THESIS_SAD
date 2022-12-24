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
            if (MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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
