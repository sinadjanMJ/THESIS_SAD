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
        DepartmentValue dv = new DepartmentValue();
        courseValue cv = new courseValue();

        public static string departmentID = "";
        public static string courseID = "";

        public RegisDean()
        {
            InitializeComponent();
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
            dgvDepartmentList.DataSource = _context.Departments.ToList();
            loadCourse();

        }
        private void loadCourse()
        {
            var res1 = (
                from cour in _context.Courses
                join deps in _context.Departments
                on cour.DepartmentID equals deps.Department_ID.ToString()

                select new courseImps
                {
                    CourseID = cour.CourseID,
                    Course_name = cour.Course_name,
                    Department_Name = deps.Department_Name
                }

                ).ToList();

            dgvCourseList.DataSource = res1;
        }

        private void btnAddDean_Click_1(object sender, EventArgs e)
        {
            DeanImport mj = new DeanImport();
            mj.Show();
        }

        private void F2_UpdateEventHandler1(object sender, DepartmentImport.UpdateEventArgs args)
        {
            dgvDepartmentList.DataSource = _context.Departments.ToList();
        }
        private void F3_UpdateEventHandler1(object sender, CourseImport.UpdateEventArgs args)
        {
            loadCourse();
        }
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            DepartmentImport std = new DepartmentImport(this);
            std.UpdateEventHandler += F2_UpdateEventHandler1;
            std.ShowDialog();
        }

        private void deletedepartment_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int departID = Int32.Parse(departmentID.ToString());
                var selectedRow = _context.Departments.Where(q => q.Department_ID == departID).FirstOrDefault();

                _context.Departments.Remove(selectedRow);
                _context.SaveChanges();
                dgvDepartmentList.DataSource = _context.Departments.ToList();
            }
            
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseImport std = new CourseImport(this);
            std.UpdateEventHandler += F3_UpdateEventHandler1;
            std.ShowDialog();
        }

        private void deletecourse_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int departID = Int32.Parse(courseID.ToString());
                var selectedRow = _context.Courses.Where(q => q.CourseID == departID).FirstOrDefault();

                _context.Courses.Remove(selectedRow);
                _context.SaveChanges();
                loadCourse();
            }
           
        }

        private void dgvDepartmentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartmentList.SelectedRows.Count > 0)
            {
                departmentID = dgvDepartmentList.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void dgvCourseList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourseList.SelectedRows.Count > 0)
            {
                courseID = dgvCourseList.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
