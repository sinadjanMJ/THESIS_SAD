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
    public partial class RegisDean : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public RegisDean()
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
            this.Hide();
            RegisDashboard mj = new RegisDashboard();
            mj.Show();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisStudent mj = new RegisStudent();
            mj.Show();
        }

        private void InstructorBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisInstructor mj = new RegisInstructor();
            mj.Show();
        }

        private void AcademicsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisAcademics mj = new RegisAcademics();
            mj.Show();
        }

        private void DeanBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisDean mj = new RegisDean();
            mj.Show();
        }

        private void RegisDean_Load(object sender, EventArgs e)
        {
            var res = (
                from dea in _context.Deans
                join dep in _context.Departments
                on dea.Department_ID equals dep.Department_ID.ToString()

                select new DeanWithDepartment
                {
                    DeanID = dea.DeanID,
                    Dean_Name = dea.Dean_fname + ", " + dea.Dean_lname,
                    Department_Name = dep.Department_Name
                }
             ).ToList();

            dgvDeanList.DataSource = res;

        }

        private void btnAddDean_Click(object sender, EventArgs e)
        {
            DeanImport mj = new DeanImport();
            mj.Show();
        }
    }
}
