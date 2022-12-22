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
    public partial class RegisSubject : Form
    {
       
   
        studentPortalEntities _context = new studentPortalEntities();

        DepartmentValue dv = new DepartmentValue();
        courseValue cv = new courseValue();

        public static string departmentID = "";
        public static string courseID = "";
        //int departID;

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
            gunaDataGridView1.DataSource = _context.Class_S.ToList();
            loadDepartment();
            dgvDepartmentList.DataSource = _context.Departments.ToList();
            loadCourse();
            loadSubs();

        }
        private void loadDepartment()
        {
            var selected = _context.Departments.ToList();

            foreach (var item in selected)
            {

                DepartmentValue dv = new DepartmentValue();
                dv.Text = item.Department_Name; //Display name
                dv.Value = item.Department_ID; //value inside the name

                cBDepartment.Items.Add(dv);
            }
            cBDepartment.SelectedIndex = 0;


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

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseImport std = new CourseImport(this);
            std.UpdateEventHandler += F3_UpdateEventHandler1;
            std.ShowDialog();
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

        private void deletedepartment_Click(object sender, EventArgs e)
        {
            int departID = Int32.Parse(departmentID.ToString());
            var selectedRow = _context.Departments.Where(q => q.Department_ID == departID).FirstOrDefault();

            _context.Departments.Remove(selectedRow);
            _context.SaveChanges();
            dgvDepartmentList.DataSource = _context.Departments.ToList();
        }

        private void dgvDepartmentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartmentList.SelectedRows.Count > 0)
            {
                departmentID = dgvDepartmentList.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void deletecourse_Click(object sender, EventArgs e)
        {
            int departID = Int32.Parse(courseID.ToString());
            var selectedRow = _context.Courses.Where(q => q.CourseID == departID).FirstOrDefault();

            _context.Courses.Remove(selectedRow);
            _context.SaveChanges();
            dgvCourseList.DataSource = _context.Courses.ToList();
        }

        private void dgvCourseList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourseList.SelectedRows.Count > 0)
            {
                courseID = dgvCourseList.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            S_Subject s = new S_Subject
            {
                SubjectCode = textSubjectCode.Text.Trim(),
                SubjectName = textSubjectName.Text.Trim()
            };

            _context.S_Subject.Add(s);
            _context.SaveChanges();

            loadSubs();
        }
        private void loadSubs()
        {
            dgvSubList.DataSource = _context.S_Subject.ToList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            Class_S cs = new Class_S
            {
                ClassName = textC_name.Text.Trim(),
                DepartmentID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString(),
                CourseID = (cBCourse.SelectedItem as courseValue).Value.ToString(),
                YearLevel = cBYear.Text.Trim()
            };

            _context.Class_S.Add(cs);
            _context.SaveChanges();
            CLEAR();

            gunaDataGridView1.DataSource = _context.Class_S.ToList();
        }

        private void cBDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBCourse.Items.Clear();
            string depID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString();
            var selectedC = _context.Courses.ToList();

            foreach (var item in selectedC)
            {
                if (item.DepartmentID == depID)
                {
                    courseValue cv = new courseValue();
                    cv.Text = item.Course_name; //Display name
                    cv.Value = item.CourseID; //value inside the name

                    cBCourse.Items.Add(cv);
                }
            }
            cBCourse.SelectedIndex = -1;
        }
        private void CLEAR()
        {
            cBCourse.Items.Clear();
            cBYear.Items.Clear();
            cBDepartment.Items.Clear();
            textC_name.Clear();
        }


    }
}
