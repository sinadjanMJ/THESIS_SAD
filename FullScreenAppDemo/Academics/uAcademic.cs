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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace FullScreenAppDemo
{
    public partial class uAcademic : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        int departmentID = 0;
        int courseID = 0;
        public static int classID = 0;
        public static int a_ID = 0;

        string fileName = "";

        public uAcademic()
        {
            InitializeComponent();
        }

        private void uAcademicDashboard_Load(object sender, EventArgs e)
        {
            dgvDepartmentList.Columns[0].Visible = false;
            dgvCourseList.Columns[0].Visible = false;
            dgvClass.Columns[0].Visible = false;

            dgvSubs.Columns[0].Visible = false;
            dgvSubs.Columns[1].Visible = false;
            dgvSubs.Columns[3].Visible = false;

            loadDepartment();
        }
        private void loadDepartment()
        {
            var res = _context.Departments.ToList();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            System.Data.DataTable dt = converter.ToDataTable(res);
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
                System.Data.DataTable dt = converter.ToDataTable(res);
                dgvClass.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error occured at loadSection()");
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvClass.SelectedRows.Count > 0)
                {
                    classID = Int32.Parse(dgvClass.SelectedRows[0].Cells[0].Value.ToString());
                    loadAcceptedGrade();
                }
            }
            catch
            {
                MessageBox.Show("Error occured at dgvClass_CellClick");
            }
        }
        private void loadAcceptedGrade()
        {
            var res = (
                from asb in _context.assignSubjects
                join tg in _context.transactionGrades on asb.a_id.ToString() equals tg.a_ID
                join sub in _context.S_Subject on asb.a_subjectID equals sub.SubjectID.ToString()
                join ins in _context.Instructors on asb.a_instructorID equals ins.InstructorID.ToString()
                join cl in _context.Class_S on asb.a_classID equals cl.ClassID.ToString()
                where cl.ClassID == classID && tg.status_Registrar == "accepted"

                select new uDeanListGrade
                {
                    a_ID = tg.a_ID,
                    SubjectID = sub.SubjectID,
                    Subject = sub.SubjectName,
                    instructorID = asb.a_instructorID,
                    instructor = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname,
                    SEMESTER = asb.a_semester
                }

                ).ToList();

            dgvSubs.DataSource = res;
        }

        private void dgvClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uAcademicStudentList mj = new uAcademicStudentList();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }

        private void dgvSubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubs.SelectedRows.Count > 0)
            {
                a_ID = Int32.Parse(dgvSubs.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void dgvSubs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var res = _context.assignSubjects.Where(q => q.a_id == a_ID).FirstOrDefault();
            if (res != null)
            {
                fileName = res.a_FileLocation;
                openFile();
            }
            else
            {
                MessageBox.Show("Entity not found.");
            }
        }
        private void openFile()
        {
            try
            {
                //MessageBox.Show(fileName);
                if (fileName != "")
                {
                    var excelApp = new Excel.Application();
                    excelApp.Visible = true;

                    Excel.Workbooks books = excelApp.Workbooks;
                    Excel.Workbook sheet = books.Open(fileName, ReadOnly: true);
                }
                else
                {
                    MessageBox.Show("File not found. Sent it back to the Instructor to create a corresponding file.");
                }
            }
            catch
            {
                MessageBox.Show("Couldn't find excel file.");
            }
        }
    }
}
