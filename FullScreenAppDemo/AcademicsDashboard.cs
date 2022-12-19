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
            AcademicsDashboardPanel.Show();
            AcademicsPendingPanel.Hide();
            AcademicsApprovedPanel.Hide();
        }

        private void ApprovedBTN_Click(object sender, EventArgs e)
        {
            AcademicsDashboardPanel.Hide();
            AcademicsPendingPanel.Hide();
            AcademicsApprovedPanel.Show();
        }

        private void PendingBTN_Click(object sender, EventArgs e)
        {
            AcademicsDashboardPanel.Hide();
            AcademicsPendingPanel.Show();
            AcademicsApprovedPanel.Hide();
        }
    }
}
