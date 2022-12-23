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
