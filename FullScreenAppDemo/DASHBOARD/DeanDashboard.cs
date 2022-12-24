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
    public partial class DeanDashboard : Form
    {
        public DeanDashboard()
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
            DeansDashboardPanel.Show();
            DeansPendingPanel.Hide();
            DeansApprovedPanel.Hide();
        }

        private void ApprovedBTN_Click(object sender, EventArgs e)
        {
            DeansDashboardPanel.Hide();
            DeansPendingPanel.Hide();
            DeansApprovedPanel.Show();
        }

        private void PendingBTN_Click(object sender, EventArgs e)
        {
            DeansDashboardPanel.Hide();
            DeansPendingPanel.Show();
            DeansApprovedPanel.Hide();
        }
    }
}
