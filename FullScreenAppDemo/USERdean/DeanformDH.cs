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
    public partial class DeanformDH : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int deanID = 0;
        string departmentID = "";
        string courseID = "";

        public static string a_id = "";
        public static string classID = "";

        public DeanformDH()
        {
            InitializeComponent();
        }

        private void dgvCourseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourseList.SelectedRows.Count > 0)
            {
                courseID = dgvCourseList.SelectedRows[0].Cells[0].Value.ToString();
                loadClassList();
                loadClass();
            }
        }
        private void loadClass()
        {
            int convertID = Int32.Parse(courseID);


            var res = (
                from cl in _context.Class_S
                join cor in _context.Courses on cl.CourseID equals cor.CourseID.ToString()
                where cor.CourseID == convertID

                select new uDeanClassWithRequestsCounter
                {
                    ClassID = cl.ClassID.ToString(),
                    ClassName = cl.ClassName,
                    YearLevel = cl.YearLevel
                }

                ).ToList();

            dgvClass.DataSource = res;
        }

        private void loadClassList()
        {
            int convertID = Int32.Parse(courseID);
            var res = _context.Courses.Where(q => q.CourseID == convertID).FirstOrDefault();

            if (res != null)
            {
                lblCourse.Text = res.Course_name;
            }

            var result = (
                from ai in _context.assignSubjects
                join cls in _context.Class_S on ai.a_classID equals cls.ClassID.ToString()
                join cor in _context.Courses on cls.CourseID equals cor.CourseID.ToString()
                join sub in _context.S_Subject on ai.a_subjectID equals sub.SubjectID.ToString()
                join tgs in _context.transactionGrades on ai.a_id.ToString() equals tgs.a_ID
                join ins in _context.Instructors on ai.a_instructorID equals ins.InstructorID.ToString()
                where cor.CourseID == convertID && tgs.status_Instructor == "sent" && tgs.status_Dean == "pending"

                select new uDeanListGrade
                {
                    a_ID = ai.a_id.ToString(),
                    ClassID = cls.ClassID,
                    Class_name = cls.ClassName,
                    Subject = sub.SubjectName.ToString(),
                    SubjectID = sub.SubjectID,
                    yearLevel = cls.YearLevel,
                    SEMESTER = ai.a_semester,
                    instructorID = ins.InstructorID.ToString(),
                    instructor = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname
                }

                ).ToList();

            dgvClassList.DataSource = result;
        }
        private void DeanformDH_Load(object sender, EventArgs e)
        {
            dgvClassList.Columns[0].Visible = false;
            dgvClassList.Columns[1].Visible = false;
            dgvClassList.Columns[3].Visible = false;
            dgvClassList.Columns[5].Visible = false;

            dgvClass.Columns[0].Visible = false;

            deanID = loginDean.deanID;
            var res = _context.Deans.Where(q => q.DeanID == deanID).FirstOrDefault();
            if (res != null)
            {
               // lblName.Text = res.Dean_fname + " " + res.Dean_mname + " " + res.Dean_lname;
                departmentID = res.Department_ID.ToString();
            }

            int convertID = Int32.Parse(departmentID);
            var res2 = _context.Departments.Where(q => q.Department_ID == convertID).FirstOrDefault();

            if (res2 != null)
            {
                lblDepartment.Text = res2.Department_Name;
            }
            CourseList();
        }
        private void CourseList()
        {
            var res = _context.Courses.Where(q => q.DepartmentID == departmentID.ToString()).ToList();

            dgvCourseList.DataSource = res;
        }

        private void dgvClassList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClassList.SelectedRows.Count > 0)
            {
                a_id = dgvClassList.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                classID = dgvClass.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgvClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeanClassList mj = new DeanClassList();
            mj.TopLevel = false;
            uipaneldh.Controls.Clear();
            uipaneldh.Controls.Add(mj);
            mj.Show();
        }
    }
}
