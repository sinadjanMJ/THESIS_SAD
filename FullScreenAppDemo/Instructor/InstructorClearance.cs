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
    public partial class InstructorClearance : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int departmentID = 0;
        public static int instructorID = 0;
        public InstructorClearance()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            RegisInstructor mj = new RegisInstructor();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }

        private void InstructorClearance_Load(object sender, EventArgs e)
        {
            dgvDepartment.Columns[0].Visible = false;
            dgvInstructor.Columns[0].Visible = false;
            loadDepartment();
        }
        private void loadDepartment()
        {
            try
            {


                var res = _context.Departments.ToList();
                if (res != null)
                {
                    dgvDepartment.DataSource = res;
                }
            }
            catch
            {

            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                departmentID = Int32.Parse(dgvDepartment.SelectedRows[0].Cells[0].Value.ToString());
                displayInstructor();
            }
        }
        private void displayInstructor()
        {
            try
            {
                var res = (
                from ins in _context.Instructors
                where ins.Department_ID == departmentID.ToString()

                select new InstructorWithDept
                {
                    InstructorID = ins.InstructorID,
                    Instructor_Name = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname
                }

                ).ToList();

                dgvInstructor.DataSource = res;
            }
            catch
            {

            }
        }

        private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                instructorID = Int32.Parse(dgvInstructor.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void dgvInstructor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InstructorClearanceDisplay mj = new InstructorClearanceDisplay();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }
    }
}
