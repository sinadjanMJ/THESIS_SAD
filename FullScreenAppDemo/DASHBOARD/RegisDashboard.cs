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
    public partial class RegisDashboard : Form
    {
        public RegisDashboard()
        {
            InitializeComponent();
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
               

            }
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            RegistarFormData mj = new RegistarFormData();
            mj.TopLevel = false;
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            RegisStudent mj = new RegisStudent();
            mj.TopLevel = false;
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void InstructorBTN_Click(object sender, EventArgs e)
        {
            RegisInstructor mj = new RegisInstructor();
            mj.TopLevel = false;
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(mj);
            mj.Show();
        }

      

        private void DeanBTN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //RegisDean mj = new RegisDean();
            //mj.Show();
            RegisDean mj = new RegisDean();
            mj.TopLevel = false;
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(mj);
            mj.Show();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            RegisSubject mj = new RegisSubject();
            mj.TopLevel = false;
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void RegisDashboard_Load(object sender, EventArgs e)
        {
            RegistarFormData mj = new RegistarFormData();
            mj.TopLevel = false;
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
                new frmlogin().Show();


            }
        }

       
    }
}
