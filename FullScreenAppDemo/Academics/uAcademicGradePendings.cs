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
    public partial class uAcademicGradePendings : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public static int classID = 0;
        public static int a_ID = 0;
        public static int subjectID = 0;
        public static int instructorID = 0;
        string fileName = "";
        string sem = "";
        public uAcademicGradePendings()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string sem = cbSemester.Text.Trim();
            var res = (
              from ai in _context.assignSubjects
              join sub in _context.S_Subject on ai.a_subjectID equals sub.SubjectID.ToString()
              join ins in _context.Instructors on ai.a_instructorID equals ins.InstructorID.ToString()
              join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
              join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
              where cl.ClassID == classID && tg.status_Dean == "accepted" && tg.status_Registrar == "pending" &&
              ai.a_semester == sem

              select new uDeanListGrade
              {
                  a_ID = ai.a_id.ToString(),
                  SubjectID = sub.SubjectID,
                  Subject = sub.SubjectName,
                  instructorID = ins.InstructorID.ToString(),
                  instructor = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname,
                  SEMESTER = ai.a_semester
              }

              ).ToList();

            dgvClassLoadList.DataSource = res;
        }

        private void uAcademicGradePendings_Load(object sender, EventArgs e)
        {

        }
        private void loadClassPendings()
        {
            var res = (
               from ai in _context.assignSubjects
               join sub in _context.S_Subject on ai.a_subjectID equals sub.SubjectID.ToString()
               join ins in _context.Instructors on ai.a_instructorID equals ins.InstructorID.ToString()
               join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
               join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
               where cl.ClassID == classID && tg.status_Dean == "accepted" && tg.status_Registrar == "pending"

               select new uDeanListGrade
               {
                   a_ID = ai.a_id.ToString(),
                   SubjectID = sub.SubjectID,
                   Subject = sub.SubjectName,
                   instructorID = ins.InstructorID.ToString(),
                   instructor = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname,
                   SEMESTER = ai.a_semester
               }

               ).ToList();

            dgvClassLoadList.DataSource = res;
        }

        private void loadLabels()
        {
            int departmentID = 0;
            int courseID = 0;
            var res = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
            if (res != null)
            {
                departmentID = Int32.Parse(res.DepartmentID);
                courseID = Int32.Parse(res.CourseID);
                lblClassName.Text = res.ClassName;
                lblYearLevel.Text = res.YearLevel;
            }

            var resDep = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();
            if (resDep != null)
            {
                lblDepartment.Text = resDep.Department_Name;
            }

            var resCourse = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();
            if (resCourse != null)
            {
                lblCourse.Text = resCourse.Course_name;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadClassPendings();
        }

        private void btnOpenGrade_Click(object sender, EventArgs e)
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var resStudProf = _context.Student_Profile.Where(q => q.ClassID == classID.ToString() && q.SubjectID == subjectID.ToString() && q.InstructorID == instructorID.ToString()).ToList();
            foreach (var item in resStudProf)
            {
                item.status = "accepted";
                _context.SaveChanges();
            }

            var resTG = _context.transactionGrades.Where(q => q.a_ID == a_ID.ToString()).FirstOrDefault();
            if (resTG != null)
            {
                resTG.feedback_Registrar = textFeedback.Text.Trim();
                resTG.status_Registrar = "accepted";
                resTG.tran_grade = "accepted";
                _context.SaveChanges();

                MessageBox.Show("Successfully sent to the Registrar's Office.");
                loadClassPendings();

            }
            else { MessageBox.Show("Entity not found!"); }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

            var res = _context.transactionGrades.Where(q => q.a_ID == a_ID.ToString()).FirstOrDefault();
            if (res != null)
            {
                res.feedback_Registrar = textFeedback.Text.Trim();
                res.status_Dean = "pending";
                res.status_Registrar = "rejected";
                _context.SaveChanges();

                MessageBox.Show("Successfully sent back to the Dean");
                loadClassPendings();
            }
            else
            {
                MessageBox.Show("Entity not found!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            uAcademicPendings mj = new uAcademicPendings();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }

        private void dgvClassLoadList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClassLoadList.SelectedRows.Count > 0)
            {
                a_ID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[0].Value.ToString());
                subjectID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[1].Value.ToString());
                instructorID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[3].Value.ToString());
                sem = dgvClassLoadList.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void uAcademicGradePendings_Load_1(object sender, EventArgs e)
        {

            dgvClassLoadList.Columns[0].Visible = false;
            dgvClassLoadList.Columns[1].Visible = false;
            dgvClassLoadList.Columns[3].Visible = false;
            if (uAcademicPendings.classID != 0)
            {
                classID = uAcademicPendings.classID;
                loadClassPendings();
                loadLabels();

            }
        }
    }
}
