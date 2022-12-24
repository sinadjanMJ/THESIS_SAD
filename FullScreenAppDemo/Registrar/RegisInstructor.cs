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
    public partial class RegisInstructor : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public RegisInstructor()
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

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            InstructorImport mj = new InstructorImport();
            mj.Show();
        }

        private void RegisInstructor_Load(object sender, EventArgs e)
        {
            var res1 = (
                from ins in _context.Instructors
                join deps in _context.Departments
                on ins.Department_ID equals deps.Department_ID.ToString()

                select new InstructorWithDept
                {
                    InstructorID = ins.InstructorID,
                    Instructor_Name = ins.Instructor_fname + ", " + ins.Instructor_lname,
                    Department_Name = deps.Department_Name
                }

                ).ToList();

            dgvInstructorList.DataSource = res1;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {

        }
    }
}
