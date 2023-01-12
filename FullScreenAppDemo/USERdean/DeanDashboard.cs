using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FullScreenAppDemo.db;
using FullScreenAppDemo.perips;

namespace FullScreenAppDemo
{
    public partial class DeanDashboard : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int deanID = 0;
        string departmentID = "";
        public DeanDashboard()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();

                this.Hide();
                SelectUserForm mj = new SelectUserForm();
                mj.Show();



            }
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            DH mj = new DH();
            mj.TopLevel = false;
            DeansDashboardPanel.Controls.Clear();
            DeansDashboardPanel.Controls.Add(mj);
            mj.Show();
        }

       

        private void PendingBTN_Click(object sender, EventArgs e)
        {
            DeanformDH mj = new DeanformDH();
            mj.TopLevel = false;
            DeansDashboardPanel.Controls.Clear();
            DeansDashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void DeanDashboard_Load(object sender, EventArgs e)
        {
            deanID = loginDean.deanID;
            var res = _context.Deans.Where(q => q.DeanID == deanID).FirstOrDefault();
            if (res != null)
            {
                label1.Text = res.Dean_fname + " " + res.Dean_mname + " " + res.Dean_lname;
                departmentID = res.Department_ID.ToString();
            }


            DH mj = new DH();
            mj.TopLevel = false;
            DeansDashboardPanel.Controls.Clear();
            DeansDashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            uDeanRejectedForm mj = new uDeanRejectedForm();
            mj.TopLevel = false;
            DeansDashboardPanel.Controls.Clear();
            DeansDashboardPanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
