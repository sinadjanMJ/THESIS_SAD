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

namespace FullScreenAppDemo
{
    public partial class RegisSubject : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public RegisSubject()
        {
            InitializeComponent();
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();

            }
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

        private void Subject_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisSubject mj = new RegisSubject();
            mj.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dgvDepartmentList.DataSource = _context.Departments.ToList();
        }

        private void RegisSubject_Load(object sender, EventArgs e)
        {
            
            dgvDepartmentList.DataSource = _context.Departments.ToList();

        }

       
        private void F2_UpdateEventHandler1(object sender, DepartmentImport.UpdateEventArgs args)
        {
            dgvDepartmentList.DataSource = _context.Departments.ToList();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            DepartmentImport std = new DepartmentImport(this);
            std.UpdateEventHandler += F2_UpdateEventHandler1;
            std.ShowDialog();
        }
    }
}
