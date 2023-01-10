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
    public partial class uAcademic : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        int departmentID = 0;
        int courseID = 0;
        public static int classID = 0;

        public uAcademic()
        {
            InitializeComponent();
        }

        private void uAcademicDashboard_Load(object sender, EventArgs e)
        {
            dgvDepartmentList.Columns[0].Visible = false;
            dgvCourseList.Columns[0].Visible = false;
            dgvClass.Columns[0].Visible = false;
            loadDepartment();
        }
        private void loadDepartment()
        {
            var res = _context.Departments.ToList();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(res);
            dgvDepartmentList.DataSource = dt;
        }

        private void dgvDepartmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDepartmentList.SelectedRows.Count > 0)
                {
                    departmentID = Int32.Parse(dgvDepartmentList.SelectedRows[0].Cells[0].Value.ToString());
                }
                /*dgvCourseList.AllowUserToAddRows = false;
                dgvCourseList.Rows.Clear();
                dgvCourseList.AllowUserToAddRows = true;*/
                loadCourse();
            }
            catch
            {
                MessageBox.Show("Error occured at dgvDepartmentList_CellClick");
            }
        }
        private void loadCourse()
        {
            try
            {
                var res = (
                    from cor in _context.Courses
                    where cor.DepartmentID == departmentID.ToString()

                    select new
                    {
                        CourseID = cor.CourseID,
                        Course_name = cor.Course_name
                    }
                    ).ToList();

                dgvCourseList.DataSource = res;
            }
            catch
            {
                MessageBox.Show("Error occured at loadCourse()");
            }
        }

        private void dgvCourseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCourseList.SelectedRows.Count > 0)
                {
                    courseID = Int32.Parse(dgvCourseList.SelectedRows[0].Cells[0].Value.ToString());
                }
                loadSection();
            }
            catch
            {
                MessageBox.Show("Error occured at CourseList_CellClick");
            }
        }
        private void loadSection()
        {
            try
            {
                var res = _context.Class_S.Where(q => q.CourseID == courseID.ToString()).ToList();
                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(res);
                dgvClass.DataSource = dt;
            }
            catch { MessageBox.Show("Error occured at loadSection()"); }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClass.SelectedRows.Count > 0)
                {
                    classID = Int32.Parse(dgvClass.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error occured at dgvClass_CellClick");
            }
        }

        private void dgvClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uAcademicStudentList mj = new uAcademicStudentList();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
