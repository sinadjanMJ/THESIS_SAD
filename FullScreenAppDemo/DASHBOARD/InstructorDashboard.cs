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
                //this.Close();
                Application.Exit();
            }
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            instructorDSHBRD mj = new instructorDSHBRD();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            Class mj = new Class();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }

        private void ValidateBTN_Click(object sender, EventArgs e)
        {
            //InstructorDashboardPanel.Hide();
            //InstructorStudentPanel.Hide();
            //ValidatePanel.Show();
        }

        private void InstructorDashboard_Load(object sender, EventArgs e)
        {
            instructorDSHBRD mj = new instructorDSHBRD();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
