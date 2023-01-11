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
    public partial class AcademicsDashboard : Form
    {
        public AcademicsDashboard()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
              this.WindowState = FormWindowState.Minimized;
        }
        

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void ApprovedBTN_Click(object sender, EventArgs e)
        {
            uAcademic mj = new uAcademic();
            mj.TopLevel = false;
            AcademicsDashboardPanel.Controls.Clear();
            AcademicsDashboardPanel.Controls.Add(mj);
            mj.Show();
        }

        private void PendingBTN_Click(object sender, EventArgs e)
        {
            uAcademicPendings mj = new uAcademicPendings();
            mj.TopLevel = false;
            AcademicsDashboardPanel.Controls.Clear();
            AcademicsDashboardPanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
